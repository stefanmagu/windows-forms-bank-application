using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1058_MAGUREANU_STEFAN.Extensions
{
    public static class DataGridViewExtensions
    {
        //public static DataGridView AddTextBoxColumn(this DataGridView dataGridView, string propertyName, string columnName)
        //{
        //    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = propertyName,
        //        Name = propertyName,
        //        HeaderText = columnName
        //    };

        //    dataGridView.Columns.Add(column);

        //    return dataGridView;
        //}

        public static DataGridView AddButtonColumn(this DataGridView dataGridView, string columnName, string labelText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = columnName,
                HeaderText = labelText,
                Text = labelText,
                UseColumnTextForButtonValue = true
            };

            dataGridView.Columns.Add(buttonColumn);

            return dataGridView;
        }
    }
}
