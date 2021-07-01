using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

using System.Text;

using System.Windows.Forms;

namespace fgAlmViewer
{
    public partial class almGrid : UserControl
    {
        
        private String sNode,sDataBase,sUser,sPassword;

        [Description("Nome do computador do banco."), Category("Banco de Dados")]
        public String Node
        {
            get
            {
                return sNode;
            }
            set
            {
                sNode = value;
            }
        }
        [Description("Nome do Banco de Dados"), Category("Banco de Dados")]
        public String DataBase
        {
            get
            {
                return sDataBase;
            }
            set
            {
                sDataBase = value;
            }
        }
        [Description("Usuário"), Category("Banco de Dados")]
        public String User
        {
            get
            {
                return sUser;
            }
            set
            {
                sUser = value;
            }
        }
        [Description("Senha"), Category("Banco de Dados")]
        public String Password
        {
            get
            {
                return sPassword;
            }
            set
            {
                sPassword = value;
            }
        }

 

        public almGrid()
        {
            InitializeComponent();
            ;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                String cs = String.Format("Server={0};Database={1};User Id={2};Password={3};", Node, DataBase, User, Password);

                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(cs))
                {
                    String qr = QueryBuilder();
                    SqlDataAdapter adap = new SqlDataAdapter(qr, conn);

                    adap.Fill(dt);
                    grdData.DataSource = dt;
                    grdData.Columns["TEMPO"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss.fff";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        String QueryBuilder()
        {

            String dInicial = dateInicial.Value.ToString("yyyy-MM-dd") + " " + timeInicial.Value.ToString("HH:mm:ss.fff");
            String dFinal = dateFinal.Value.ToString("yyyy-MM-dd") + " " + timeFinal.Value.ToString("HH:mm:ss.fff");
            String kind = "AE";
            foreach (Object o in grdTipo.Controls)
            {
                RadioButton rd = (RadioButton)o;
                if (rd.Checked)
                {
                    kind = rd.Tag.ToString();
                    break;
                }
            }
            #region Alarm Query

            String[] AlarmCols = new String[10];
            AlarmCols[0] = "M.TagName,";
            AlarmCols[1] = "D.OperatorName,";
            AlarmCols[2] = "M.ValueString,";
            AlarmCols[3] = "M.Priority as Prioridade,";
            AlarmCols[4] = "M.GroupName,";        
            AlarmCols[5] = "M.Time AS TEMPO,";
            AlarmCols[6] = "C.Comment,";
            AlarmCols[7] = @"'Alarme' as TIPO,";
            AlarmCols[8] = @"D.OperatorNode,";
            AlarmCols[9] = @"D.AlarmState as 'Estado',";
            

            String AlarmQuery = "SELECT ";

            foreach (String s in AlarmCols)
            {
                AlarmQuery = AlarmQuery + s;
            }
            AlarmQuery = AlarmQuery.Remove(AlarmQuery.Length-1);
            AlarmQuery = AlarmQuery + " FROM AlarmMaster AS M" +" LEFT JOIN AlarmDetail AS D" +" ON M.AlarmId = D.AlarmId"+
                        " LEFT JOIN Comment AS C"+ " ON D.CommentId = C.CommentId";

            #region WHERE CLAUSE

                String comentWhere = "";
                if(edtComment.Text.Length > 0)
                {
                comentWhere = String.Format(" AND C.Comment like '%{0}%'", edtComment.Text);
                }
            AlarmQuery = AlarmQuery +
            String.Format(" WHERE M.Time >= '{0}' AND M.Time <= '{1}'", dInicial, dFinal)
            + String.Format(" AND M.TagName like '%{0}%' AND D.OperatorName like '%{1}%'", edtTagName.Text, edtUser.Text)
            + String.Format("AND M.Priority between {0} and {1}",spinFrom.Value.ToString(),spinTo.Value.ToString())
            + comentWhere;


                #endregion
            #endregion

            #region Event Query
                String[] EvtCols = new String[10];
                EvtCols[0] = "TagName,";
                EvtCols[1] = "OperatorName,";
                EvtCols[2] = "ValueString as Value,";
                EvtCols[3] = "NULL as Prioridade,";
                EvtCols[4] = "GroupName,";
                EvtCols[5] = "EventStamp AS Tempo,";
                EvtCols[6] = "Comment,";
                EvtCols[7] = @"'Evento' as Tipo,";
                EvtCols[8] = @"OperatorNode,";
                EvtCols[9] = @"'ND' as 'Estado',";

            String EvtQuery = "SELECT ";

                foreach (String s in EvtCols)
                {
                    EvtQuery = EvtQuery + s;
                }
                EvtQuery = EvtQuery.Remove(EvtQuery.Length - 1);

                EvtQuery = EvtQuery + " FROM Events";
          
                #region WHERE CLAUSE


                EvtQuery = EvtQuery +
                String.Format(" WHERE EventStamp >= '{0}' AND EventStamp <= '{1}'", dInicial, dFinal)
                + String.Format(" AND TagName like '%{0}%' AND OperatorName like '%{1}%' AND Comment like '%{2}%' ", edtTagName.Text, edtUser.Text, edtComment.Text);


                #endregion

            #endregion

            #region FinalQueryBuilder
                if (kind == "A")
                {
                    return AlarmQuery;
                }
                else if (kind == "E")
                {
                    return EvtQuery;
                }
                else if (kind == "AE")
                {
                    return AlarmQuery + " UNION " + EvtQuery;
                }
                else
                {
                    return "FAIL";
                }

            #endregion

        }


    }
}
