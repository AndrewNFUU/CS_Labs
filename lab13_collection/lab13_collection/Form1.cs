using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab13_collection
{
    public partial class frmStart : Form
    {
        DStringCollection queue = new DStringCollection();
        DStringCollectionGeneric genericQueue = new DStringCollectionGeneric();

        public frmStart()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            try
            {
                queue = new DStringCollection();
                genericQueue = new DStringCollectionGeneric();
                if (int.TryParse(txtNumOfElements.Text, out int size))
                {
                    if (size > 10 || size < 0)
                    {
                        MessageBox.Show("Size cannot more than 10 elements" +
                            "\n         or be less than 0.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (radioBtnQueue.Checked)
                    {
                        txtOutput.Text = "";
                        queue.Clear();
                        queue.FillQueue(size);

                        foreach (var num in queue)
                        {
                            txtOutput.AppendText(num.ToString() + "  ");
                        }
                    }

                    if (radioBtnGenericQueue.Checked)
                    {
                        txtOutput.Text = "";
                        genericQueue.Clear();
                        genericQueue.FillGenericQueue(size);

                        foreach (var num in genericQueue)
                        {
                            txtOutput.AppendText(num.ToString() + "  ");
                        }
                    }

                    else
                    {
                        throw new Exception("Error while filling queue.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for size.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtRemove.Text, out int elementToRemove))
                {
                    bool removed = false;

                    //     R E G U L A R     Q U E U E
                    if (radioBtnQueue.Checked)
                    {
                        Queue tempQueue = new Queue();

                        while (queue.Count() > 0)
                        {
                            var item = queue.RemoveFromQueue();
                            if (!item.ToString().Equals(elementToRemove.ToString()))
                            {
                                tempQueue.Enqueue(item);
                            }
                            else
                            {
                                removed = true;
                            }
                        }

                        // Reassign the modified queue back to the original queue
                        queue = new DStringCollection();
                        foreach (var item in tempQueue)
                        {
                            queue.AddToQueue(item);
                        }

                        if (!removed)
                        {
                            throw new Exception("Element not found in the queue.");
                        }

                        // Refresh the output display after removal
                        txtOutput.Clear();
                        foreach (var num in queue)
                        {
                            txtOutput.AppendText(num.ToString() + "  ");
                        }
                    }
                    //      G E N E R I C     Q U E U E
                    else if (radioBtnGenericQueue.Checked)
                    {
                        Queue<DecimalString> tempQueue = new Queue<DecimalString>();

                        while (genericQueue.Count() > 0)
                        {
                            var item = genericQueue.RemoveFromGenericQueue();
                            if (!item.ToString().Equals(elementToRemove.ToString()))
                            {
                                tempQueue.Enqueue(item);
                            }
                            else
                            {
                                removed = true;
                            }
                        }

                        // Reassign the modified queue back to the original queue
                        genericQueue = new DStringCollectionGeneric();
                        foreach (var item in tempQueue)
                        {
                            genericQueue.AddToGenericQueue(item);
                        }

                        if (!removed)
                        {
                            throw new Exception("Element not found in the queue.");
                        }

                        // Refresh the output display after removal
                        txtOutput.Clear();
                        foreach (var num in genericQueue)
                        {
                            txtOutput.AppendText(num.ToString() + "  ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a queue type.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number to remove.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                txtCount.Text = "";
                decimal sum = 0;

                if (radioBtnQueue.Checked)
                {
                    //     R E G U L A R     Q U E U E 
                    foreach (var num in queue)
                    {
                        if (decimal.TryParse(num.ToString(), out decimal value))
                        {
                            sum += value;
                        }
                        else
                        {
                            throw new Exception($"Invalid number in queue: {num}");
                        }
                    }
                }
                else if (radioBtnGenericQueue.Checked)
                {
                    //      G E N E R I C     Q U E U E
                    foreach (var num in genericQueue)
                    {
                        if (decimal.TryParse(num.ToString(), out decimal value))
                        {
                            sum += value;
                        }
                        else
                        {
                            throw new Exception($"Invalid number in queue: {num}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a queue type.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtCount.Text = sum.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFindPosition_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtElement.Text, out int numberToFind))
                {
                    int index = -1;
                    int currentIndex = 0;

                    if (radioBtnQueue.Checked)
                    {
                        //     R E G U L A R     Q U E U E 
                        foreach (var item in queue)
                        {
                            if (item.ToString() == numberToFind.ToString())
                            {
                                index = currentIndex + 1;
                                break;
                            }
                            currentIndex++;
                        }
                    }
                    else if (radioBtnGenericQueue.Checked)
                    {
                        //      G E N E R I C     Q U E U E
                        foreach (var item in genericQueue)
                        {
                            if (item.ToString() == numberToFind.ToString())
                            {
                                index = currentIndex + 1;
                                break;
                            }
                            currentIndex++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a queue type.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    txtPosition.Text = index >= 0 ? index.ToString() : throw new Exception("Number not found in queue.");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number to find.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"An error occurred: {exception.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
