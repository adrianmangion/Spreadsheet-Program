using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adrian_Spreadsheet
{
    class Cell : System.Windows.Forms.TextBox
    {

        private char cellLetter;
        private int cellNumber;
        private string cellID;

        public char CellLetter
        {
            get { return cellLetter; }
            set { cellLetter = value; }
        }

        public int CellNumber
        {
            get { return cellNumber; }
            set { cellNumber = value; }
        }

        public string CellID
        {
            get { return cellID; }
            set { cellID = CellLetter + Convert.ToString(CellNumber); }
        }

        public TextBox createCell()
        {
            TextBox cell = new TextBox();
            cell.AcceptsReturn = true;
            cell.Name = cellID;
            //cell
            cell.Margin = new Padding(0,0,0,0);
            //Textb
            return cell;
        }

        public void clearCell(TextBox cell)
        {
            cell.Text = "";
        }
    }
}
