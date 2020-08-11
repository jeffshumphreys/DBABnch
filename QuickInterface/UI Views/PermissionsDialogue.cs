using QuickInterface.DataFetchers;
using QuickInterface.UI_Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xunit;
using static QuickInterface.DataFetchers._DataFetcherBase;
using static QuickInterface.Globals;
using static QuickInterface.Program;

namespace QuickInterface.UI_Views
{
    public partial class PermissionsDialogue : Form
    {
        public PermissionsDialogue()
        {
            InitializeComponent();
        }

        private void PermissionsDialogue_Load(object sender, EventArgs e)
        {
            // TODO: Set on last button used?
            // TODO: list of last actions and outcomes?
        }

            private async void fillInMissingDetails_Click(object sender, EventArgs e)
        {
            string soughtPersonsName = null;

            if (ReceiverNamesSoughtOrFound.SelectedItem == null)
            {
                soughtPersonsName = ReceiverNamesSoughtOrFound.Text.Trim(); // They typed a non-list item, which is of course what they are supposed to do.
            }
            else
            {
                soughtPersonsName = ReceiverNamesSoughtOrFound.SelectedItem.ToString().Trim();
            }

            Assert.NotNull(soughtPersonsName);
            Assert.NotEmpty(soughtPersonsName);

            this.UseWaitCursor = true;
            // Tuples. Because a class defining a dataset's content is never populated with metadata, but we need the metadata at the same time!  For example, if it failed, timed out, couldn't connect, ran out of connections in the pool, no such SP, yada yada yada
            (List<SearchPersonReturns> response, SPJobDef spReturns) = await new FetchSPReturns().RunSearchPersonRtnResults(soughtIdentifier: soughtPersonsName, callingInterface: new _WinFormsCallingInterface(returnMessagesToThisForm: this, returnMessagesToThisControl: outTxtRunProcMessages, WriteSPRowsToThisGrid: responseFromQueryAsGrid));

            if (spReturns.errorNo == NO_SQL_ERROR_RETURNED)
            {
                lastStatusMessage.Text = $"Ran successfully";
                if (spReturns.SPReturnValue == SP_SUCCEEDED_EXACTLY_AS_REQUESTED)
                {
                    lastStatusMessage.Text = $"Found a match";
                    this.BackColor = Color.LightGreen;
                } else if (spReturns.SPReturnValue == SP_FAILED_TO_FIND_WHAT_WAS_REQUESTED)
                {
                    lastStatusMessage.Text = $"Unable to find a match for '{soughtPersonsName}";
                    this.BackColor = Color.LightSalmon;
                } else if (spReturns.SPReturnValue == SP_REACHED_UNREACHABLE_CODE)
                {
                    lastStatusMessage.Text = $"Unable to find a match for '{soughtPersonsName}";
                    this.BackColor = Color.LightSalmon;
                }
                else if (spReturns.SPReturnValue == SP_SUCCEEDED_RETURNED_POSSIBLE_OPTIONS)
                {
                    lastStatusMessage.Text = $"Found similar items that partially matched '{soughtPersonsName}";
                    this.BackColor = Color.LightGoldenrodYellow;
                }
            }
            else
            {
                this.BackColor = Color.Red;
                lastStatusMessage.Text = $"Error # {spReturns.errorNo}";
            }

            this.UseWaitCursor = false;
        }

        private void Connection_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {
            outTxtRunProcMessages.AppendLine(e.Message);
        }

        private void cancelOpAndCloseWindowCommand_Click(object sender, EventArgs e)
        {
            Close(); // No save, no nothin.
        }
    }
}
