using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrian_Spreadsheet
{
    public partial class form_spreadsheet : Form
    {
        Label[] cellLetters = new Label[26];
        Label[] cellNumbers = new Label[26];
        Cell[,] cell = new Cell[26,26];
        int x = 30; //do +50
        int y = 85;
        int xLetterLabels = 30;
        int yLetterLabels = 65;
        int xNumLabels = 0;
        int yNumLabels = 85;
        char cellLetter = 'A';
        int cellNumber = 1;

        public form_spreadsheet()
        {
            InitializeComponent();
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;

                button.BackColor = Color.MediumSeaGreen;
                button.ForeColor = Color.White;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.SeaGreen;

        }

        private void Btn_newSheet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cellLetters.Length; i++)
            {
                cellLetters[i] = new Label();
                cellLetters[i].BorderStyle = BorderStyle.None;
                cellLetters[i].Text = Convert.ToString(cellLetter);
                cellLetters[i].Size = new System.Drawing.Size(45,20);
                cellLetters[i].Location = new Point(xLetterLabels,yLetterLabels);
                cellLetters[i].Margin = new Padding(0,0,0,0);
                this.Controls.Add(cellLetters[i]);
                xLetterLabels += 53;
                cellLetter++;
            } //When label is double clicked I want to resize all cells in that column

            for (int i = 0; i < cellNumbers.Length; i++)
            {
                cellNumbers[i] = new Label();
                cellNumbers[i].BorderStyle = BorderStyle.None;
                cellNumbers[i].Text = Convert.ToString(cellNumber);
                cellNumbers[i].Size = new System.Drawing.Size(29, 20);
                cellNumbers[i].Location = new Point(xNumLabels,yNumLabels);
                cellNumbers[i].Margin = new Padding(0,0,0,0);
                this.Controls.Add(cellNumbers[i]);
                yNumLabels += 20;
                cellNumber++;
            } //Same with rows

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    cell[i, j] = new Cell();
                    cell[i, j].Margin = new Padding(0,0,0,0);
                    cell[i, j].Location = new Point(x, y);
                    cell[i,j].CellLetter = cellLetter;
                    cell[i,j].CellNumber = cellNumber;
                    cell[i,j].Size = new System.Drawing.Size(50, 20);
                    this.Controls.Add(cell[i, j].createCell());
                    cellLetter++;
                    cellNumber++;
                    x += 50;
                }
                y = y + 85;
            }
        }

        private void Btn_changeTheme_Click(object sender, EventArgs e)
        {
            string tempColor = Convert.ToString(this.panel_menu.BackColor);
            this.panel_menu.BackColor = Color.DarkBlue;
            btn_changeTheme.BackColor = Color.DarkBlue;
            btn_newSheet.BackColor = Color.DarkBlue;
            btn_formulas.BackColor = Color.DarkBlue;
            btn_charts.BackColor = Color.DarkBlue;
            btn_setting.BackColor = Color.DarkBlue;
        }
    }
}
