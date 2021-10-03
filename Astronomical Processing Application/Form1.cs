using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Kris Tribbeck & Kyle Watson - Team Fast Koalas - Sprint 1.
// Date: 13/08/2021
// Version 2.
// Astronomical Processing Application.
// Application for recording neutrino interactions per hour over a day.
// Accepts user input in integer form. Processes include adding, deleting, editing, searching and sorting of existing values. Values are displayed in a list box.
namespace Astronomical_Processing_Application
{
    public partial class Application1 : Form
    {
        public Application1()
        {
            InitializeComponent();
        }
        #region Array Initialisation
        static int max = 24;
        int[] myArray = new int[max];
        int nextEmptyValue = 0;
        #endregion
        #region Random Button Functionality
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            FillArray();
            DisplayArray();
        }
        #endregion
        #region Display Array
        private void DisplayArray()
        {
            ListBoxDisplay.Items.Clear();
            try
            {
                for (int x = 0; x < (nextEmptyValue); x++)
                {
                    if (myArray[x] != 0)
                    {
                        ListBoxDisplay.Items.Add(myArray[x]);
                    }
                }
            }
            catch
            {
                StripStatusMsg.Text = "Array full, please delete a value before attempting to add another.";
            }

        }
        #endregion
        #region Fill Array Method
        private void FillArray()
        {

            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                nextEmptyValue++;
                myArray[i] = rand.Next(10, 100);
                DisplayArray();
            }

        }
        #endregion
        #region Sort Array Method
        private void SortArray()
        {
            int temp;
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        temp = myArray[j + 1];
                        myArray[j + 1] = myArray[j];
                        myArray[j] = temp;
                    }
                    DisplayArray();
                    Application.DoEvents();
                    TextBoxDisplay.Text = j.ToString();
                    TextBoxDisplay.Clear();
                }
            }
        }
        #endregion
        #region Add Button
        private void ButtonAddData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TextBoxDisplay.Text))
                {
                    myArray[nextEmptyValue] = int.Parse(TextBoxDisplay.Text);
                    Array.Sort(myArray, 0, nextEmptyValue);
                    nextEmptyValue++;
                    DisplayArray();
                    TextBoxDisplay.Clear();
                    TextBoxDisplay.Focus();
                }
                else
                    StripStatusMsg.Text = "Add number failed: Input box is empty";
            }
            catch (System.IndexOutOfRangeException)
            {
                StripStatusMsg.Text = "Array full. Please delete a value before attempting again.";
            }
            catch
            {
                StripStatusMsg.Text = "Please enter a valid integer input.";
            }
        }
        #endregion
        #region Delete Button
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListBoxDisplay.SelectedIndex != -1)
            {
                string currentItem = ListBoxDisplay.SelectedItem.ToString();
                int taskIndex = ListBoxDisplay.FindString(currentItem);
                DialogResult deleteTask = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteTask == DialogResult.Yes)
                {
                    myArray[taskIndex] = myArray[nextEmptyValue - 1];
                    StripStatusMsg.Text = "Deleted";
                    nextEmptyValue--;
                    //SortArray();
                    DisplayArray();
                    TextBoxDisplay.Clear();

                }
                else
                    StripStatusMsg.Text = "Value to delete.";
            }
            else
            {
                StripStatusMsg.Text = "Please select a value to delete.";
            }
        }
        #endregion
        #region Text Box Selection Display
        private void ListBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxDisplay.SelectedIndex != -1)
            {
                string currentItem = ListBoxDisplay.SelectedItem.ToString();
                int findNumIndex = ListBoxDisplay.FindString(currentItem);
                TextBoxDisplay.Text = myArray[findNumIndex].ToString();
            }
            else
                StripStatusMsg.Text = "Please select a number from the list.";
        }
        #endregion
        #region Binary Search Button
        private void ButtonSearch_Click(object sender, EventArgs e)
        {

            try
            {
                int mid = 0;
                    int lowBound = 0;
                    int highBound = max - 1;
                    int target = int.Parse(TextBoxDisplay.Text);
                    bool found = false;


                    if (!(Int32.TryParse(TextBoxDisplay.Text, out target)))
                    {
                        StripStatusMsg.Text = "Enter a number";
                    }

                    while (lowBound <= highBound)
                    {
                        mid = (lowBound + highBound) / 2;


                        if (target == myArray[mid])
                        {

                            found = true;
                            break;

                        }
                        else if (target < myArray[mid])
                        {
                            highBound = mid - 1;
                        }
                        else
                        {
                            lowBound = mid + 1;
                        }

                    }
                    if (found)
                    {
                        StripStatusMsg.Text = "Found at element [" + mid + "]";
                        ListBoxDisplay.SelectedIndex = mid;
                        TextBoxDisplay.Text = myArray[mid].ToString();
                        TextBoxDisplay.Clear();
                    }
                    else
                        StripStatusMsg.Text = "Array does not contain specified value.";
            }
            catch (System.FormatException)
            {
                StripStatusMsg.Text = "Text box cannot be empty. ";
            }
        }
        #endregion
        #region Bubble Sort Button
        private void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            SortArray();
        }
        #endregion
        #region Edit Button
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListBoxDisplay.SelectedIndex != -1)
                {
                    ListBoxDisplay.Text = ListBoxDisplay.SelectedIndex.ToString();
                    int indexSelected = ListBoxDisplay.SelectedIndex;
                    int selectedValue = myArray[indexSelected];
                    String newInput = TextBoxDisplay.Text;
                    int newInputInteger = Convert.ToInt32(newInput);
                    if (newInputInteger >= 0)
                    {
                        myArray[indexSelected] = newInputInteger;
                    }
                    else
                    {
                        StripStatusMsg.Text = "Please enter a valid integer input.";
                    }
                }
                else
                {
                    StripStatusMsg.Text = "Please enter a valid integer input.";
                }
            }
            catch (System.FormatException)
            {
                StripStatusMsg.Text = "Please enter a valid integer input.";
            }
            DisplayArray();
            TextBoxDisplay.Clear();
        }
        #endregion
        #region User Input Handling
        private void TextBoxDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Misc Code
        private void StripStatusDisplayMsg_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
