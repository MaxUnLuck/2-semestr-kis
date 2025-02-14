using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_2_1_Sulemanov
{
    internal class ListEdit
    {
        string[] texts;
        public ListEdit(string text) 
        {
            try
            {
                texts = text.Split(' ');
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GetList()
        {
            string newText = string.Empty;
            try
            {
                List<double> nums = new List<double> { };
                for (int i = 0; i < texts.Length; i++)
                {
                    try
                    {
                        nums.Add(Convert.ToDouble(texts[i]));
                    }
                    catch (Exception ex) { }
                }
                List<double> newnums = new List<double> { };
                for (int i = 0; i < nums.Count + 1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        newnums.Add(nums[j]);
                    }
                }
                for (int i = 0; i < newnums.Count; i++)
                {
                    newText += Convert.ToString(newnums[i]) + " ";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return newText;
        }
    }
}
