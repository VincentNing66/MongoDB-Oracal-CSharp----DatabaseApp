using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string searchingWith = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void oracleConnect(string searching)
        {
            try
            {
                string searchCol = "";
                if (searching == "games")
                    searchCol = "gID";
                else if (searching == "teams")
                    searchCol = "tID";
                else if (searching == "players")
                    searchCol = "playerTag";
                else
                    MessageBox.Show("Could not find the right database!");
            
                string ConString = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching.cms.waikato.ac.nz;User Id=COMPX323_05;Password=fKsQujpmAX;";
                {
                    OracleConnection conn = new OracleConnection(ConString);
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    if (searching == "games")
                        cmd.CommandText = $"SELECT * FROM {searching} WHERE {searchCol} = '{textBox1.Text}'";
                    else if (searching == "teams")
                        cmd.CommandText = $"select t.tID, t.teamName, g.gameName from teams t inner join games g on t.game = g.gId where {searchCol} = '{textBox1.Text}'";
                    else if (searching == "players")
                        cmd.CommandText = $"select p.playerTag, p.firstName, p.lastName, t.teamName from players p inner join teams t on p.team = t.tId where {searchCol} = '{textBox1.Text}'";
                    else
                        MessageBox.Show("Cannot find the table of "+ searching);
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    try
                    {
                        if (searching == "games")
                        {
                            text1_r.Text = dr.GetString(2).ToString();
                            text2_r.Text = dr.GetInt32(0).ToString();
                            text3_r.Text = dr.GetString(1).ToString();
                            text4_r.Text = dr.GetString(3).ToString();
                        }
                        else if (searching == "teams")
                        {
                            text1_r.Text = dr.GetString(1).ToString();
                            text2_r.Text = dr.GetInt32(0).ToString();
                            text3_r.Text = dr.GetString(2).ToString();
                        }

                        else if (searching == "players")
                        {
                            text1_r.Text = dr.GetString(0).ToString();
                            text2_r.Text = dr.GetString(1).ToString();
                            text3_r.Text = dr.GetString(2).ToString();
                            text4_r.Text = dr.GetString(3).ToString();
                        }
                        else
                            MessageBox.Show("Error with printing out the data!");
                        conn.Dispose();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Input!");
                    }
               

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void HeadText_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void handleShowText()
        {
            text1.Visible = true;
            text1_r.Visible = true;
            
            text2.Visible = true;
            text2_r.Visible = true;
            
            text3.Visible = true;
            text3_r.Visible = true;
           
            text4.Visible = true;
            text4_r.Visible = true;
            
        }

        private void SearchGame_Click(object sender, EventArgs e)
        {
            searchingWith = "games";
            handleShowText();
            textBox1.Visible = true;
            SearchBtn.Visible = true;
            HeadText.Text = "Please search with a Game ID";
            text1.Text = "Game Name : ";
            text1_r.Text = "";
            text2.Text = "Game ID : ";
            text2_r.Text = "";
            text3.Text = "Game Platform : ";
            text3_r.Text = "";
            text4.Text = "Game Developer : ";
            text4_r.Text = "";
        }

        private void SearchTeam_Click(object sender, EventArgs e)
        {
            searchingWith = "teams";
            textBox1.Visible = true;
            SearchBtn.Visible = true;
            handleShowText();
            HeadText.Text = "Please search with a team ID";
            text1.Text = "Team Name : ";
            text1_r.Text = "";
            text2.Text = "Team ID : ";
            text2_r.Text = "";
            text3.Text = "Game Playing : ";
            text3_r.Text = "";
            text4.Visible = false;
            text4_r.Visible = false;
        }

        private void SearchPlayer_Click(object sender, EventArgs e)
        {
            searchingWith = "players";
            textBox1.Visible = true;
            SearchBtn.Visible = true;
            handleShowText();
            HeadText.Text = "Please search with a player tag";
            text1.Text = "Player Tag : ";
            text1_r.Text = "";
            text2.Text = "Player First Name : ";
            text2_r.Text = "";
            text3.Text = "Player Last Name : ";
            text3_r.Text = "";
            text4.Text = "Team : ";
            text4_r.Text = "";
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            oracleConnect(searchingWith);
        }

        private void outputtext_Click(object sender, EventArgs e)
        {

        }

        private void gameName_Click(object sender, EventArgs e)
        {

        }

        private void gameId_Click(object sender, EventArgs e)
        {

        }

        private void gameDeveloper_Click(object sender, EventArgs e)
        {

        }

        private void gamePlatform_Click(object sender, EventArgs e)
        {

        }

        private void showPanTeam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showPanPlayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gameName_r_Click(object sender, EventArgs e)
        {

        }

        private void gameId_r_Click(object sender, EventArgs e)
        {

        }

        private void gamePlatform_r_Click(object sender, EventArgs e)
        {

        }

        private void gameDeveloper_r_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPanGame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
