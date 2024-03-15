using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
namespace TesztReq
{
    public partial class FormMain : Form
    {
        public BindingList<User> users;
        public const string url = "https://reqres.in/api/users";
        public FormMain()
        {
            InitializeComponent();
            users = new BindingList<User>();
        }
        #region Button events
        private async void btnStart_Click(object sender, EventArgs e)
        {
            DialogResult msgRes = MessageBox.Show("Do you want to request actual data from server?", "Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msgRes == DialogResult.Yes)
            {
                users.Clear();
                await GetActualData();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close application?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgData.DataSource != null && users.Count != 0)
            {
                MessageBox.Show($"Selected Data\n" +
                    $"\nId: {dgData.SelectedRows[0].Cells["Id"].Value}" +
                    $"\nFirst name: {dgData.SelectedRows[0].Cells["FirstName"].Value}" +
                    $"\nLast name: {dgData.SelectedRows[0].Cells["LastName"].Value}" +
                    $"\nEmail: {dgData.SelectedRows[0].Cells["Email"].Value}" +
                    $"\nAvailable avatar? {dgData.SelectedRows[0].Cells["Avatar"].Value?.ToString()?.Length > 0}" +
                    $"", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please request informations from server!");
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgData.SelectedRows != null)
            {
                User selectedUser = users.Where(x => x.Id.Equals(dgData.SelectedRows[0].Cells["Id"].Value)).First();
                if (MessageBox.Show($"Do you want to remove {selectedUser.FirstName} {selectedUser.LastName} from local list?\n\nThe action not affected on this server!", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    users.Remove(selectedUser);
                }
            }
        }
        #endregion
        #region DataGridView Settings - Events
        private void dgData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgData.RowCount != 0)
            {
                //switch (dgData.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection)
                //{
                //    case SortOrder.None:
                //        //Ascending
                //        dgData.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                //        users?.OrderBy(x => dgData.Columns[e.ColumnIndex].DataPropertyName);
                //        break;
                //    case SortOrder.Ascending:
                //        //Descending
                //        dgData.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                //        users?.OrderByDescending(x => dgData.Columns[e.ColumnIndex].DataPropertyName);
                //        break;
                //    case SortOrder.Descending:
                //        //None - ascending default
                //        dgData.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                //        users?.OrderBy(x => dgData.Columns[e.ColumnIndex].DataPropertyName);
                //        break;
                //    default:
                //        break;
                //}
            }
        }
        #endregion
        #region Requests from API
        private async Task GetActualData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string respString = await response.Content.ReadAsStringAsync();
                        JToken datas = JObject.Parse(respString);
                        users.RaiseListChangedEvents = false;
                        foreach (var data in datas?["data"])
                        {
                            users.Add(new User(
                                id: Convert.ToInt32(data?["id"]),
                                firstName: Convert.ToString(data?["first_name"]),
                                lastName: Convert.ToString(data?["last_name"]),
                                avatar: Convert.ToString(data?["avatar"]),
                                email: Convert.ToString(data?["email"])
                                ));
                        }
                        users.RaiseListChangedEvents = true;
                        dgData.DataSource = users;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
