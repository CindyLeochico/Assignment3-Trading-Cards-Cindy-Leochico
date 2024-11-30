using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TrendingCards
{
    public partial class Form1 : Form
    {

        private List<Player> players;
        public Form1()
        {
            InitializeComponent();
            InitializePlayers();
            BindTeams();
            BindPlayerList();

        }
        private void InitializePlayers()
        {
            players = new List<Player>
            {
                new Player { Name = "Select Player", Team = "Lakers", Position = "Small Forward", Points = 27, Assists = 7, Rebounds = 8, Steals = 1, PhotoPath =  "" },
                new Player { Name = "LeBron James", Team = "Lakers", Position = "Small Forward", Points = 27, Assists = 7, Rebounds = 8, Steals = 1, PhotoPath =  @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\LeBron.jpg" },
                new Player { Name = "Anthony Davis", Team = "Lakers", Position = "Power Forward", Points = 24, Assists = 3, Rebounds = 11, Steals = 2, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Davis.jpg" },
                new Player { Name = "Russell Westbrook", Team = "Lakers", Position = "Point Guard", Points = 18, Assists = 8, Rebounds = 7, Steals = 1, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Westbrook.jpg" },
                new Player { Name = "Stephen Curry", Team = "Warriors", Position = "Point Guard", Points = 30, Assists = 6, Rebounds = 5, Steals = 1, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Curry.jpg" },
                new Player { Name = "Draymond Green", Team = "Warriors", Position = "Power Forward", Points = 8, Assists = 7, Rebounds = 7, Steals = 1, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Green.png" },
                new Player { Name = "Klay Thompson", Team = "Warriors", Position = "Shooting Guard", Points = 20, Assists = 2, Rebounds = 4, Steals = 1, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Thompson.jpg" },
                new Player { Name = "Kevin Durant", Team = "Nets", Position = "Small Forward", Points = 29, Assists = 5, Rebounds = 7, Steals = 1, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Durant.jpg" },
                new Player { Name = "Kyrie Irving", Team = "Nets", Position = "Point Guard", Points = 27, Assists = 6, Rebounds = 4, Steals = 1, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Irving.jpg"},
                new Player { Name = "James Harden", Team = "Nets", Position = "Shooting Guard", Points = 24, Assists = 8, Rebounds = 5, Steals = 1, PhotoPath = @"C:\Users\Cindy\OneDrive\Desktop\code\TrendingCards\TrendingCards\Images\Harden.jpg" },
            };
        }
        private void BindTeams()
        {
            var teams = players.Select(p => p.Team).Distinct().ToList();
            teams.Insert(0, "All Teams"); // Add "All Teams" for no filter
            comboBoxTeams.DataSource = teams;
        }

        private void BindPlayerList()
        {
            var selectedTeam = comboBoxTeams.SelectedItem?.ToString();
            var filteredPlayers = string.IsNullOrEmpty(selectedTeam) || selectedTeam == "All Teams"
                ? players
                : players.Where(p => p.Team == selectedTeam).ToList();

            listBoxPlayers.DataSource = filteredPlayers;
            listBoxPlayers.DisplayMember = "Name";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPlayerList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Get the information from the textboxes and numeric fields
            var playerName = textBoxName.Text;
            var playerTeam = textBoxTeam.Text;
            var playerPosition = textBoxPosition.Text;
            var playerPoints = (int)numericUpDownPoints.Value;
            var playerAssists = (int)numericUpDownAssists.Value;
            var playerRebounds = (int)numericUpDownRebounds.Value;
            var playerSteals = (int)numericUpDownSteals.Value;
            var playerPhotoPath = textBoxPhotoPath.Text;

            // Check if the necessary fields are not empty
            if (string.IsNullOrEmpty(playerName) || string.IsNullOrEmpty(playerTeam) || string.IsNullOrEmpty(playerPosition))
            {
                MessageBox.Show("Please fill in all the fields before adding the player.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new Player object with the provided details
            var newPlayer = new Player
            {
                Name = playerName,
                Team = playerTeam,
                Position = playerPosition,
                Points = playerPoints,
                Assists = playerAssists,
                Rebounds = playerRebounds,
                Steals = playerSteals,
                PhotoPath = playerPhotoPath
            };

            // Add the new player to the list
            players.Add(newPlayer);

            // Refresh the ListBox by resetting its DataSource
            listBoxPlayers.DataSource = null; // Reset the binding
            listBoxPlayers.DataSource = players; // Rebind the list
            listBoxPlayers.DisplayMember = "Name"; // Display only player names

            // Automatically select the new player in the ListBox
            listBoxPlayers.SelectedItem = newPlayer;

            // Clear the form fields for the user to fill out
            ClearForm();

            // Display a success message
            MessageBox.Show("New player added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                // Update the player's details with the values from the textboxes
                selectedPlayer.Name = textBoxName.Text;
                selectedPlayer.Team = textBoxTeam.Text;
                selectedPlayer.Position = textBoxPosition.Text;
                selectedPlayer.Points = int.Parse(numericUpDownPoints.Value.ToString());
                selectedPlayer.Assists = int.Parse(numericUpDownAssists.Value.ToString());
                selectedPlayer.Rebounds = int.Parse(numericUpDownRebounds.Value.ToString());
                selectedPlayer.Steals = int.Parse(numericUpDownSteals.Value.ToString());
                selectedPlayer.PhotoPath = textBoxPhotoPath.Text;

                // Refresh the list to reflect the changes (optional)
                listBoxPlayers.DataSource = null;
                listBoxPlayers.DataSource = players;
                listBoxPlayers.DisplayMember = "Name";

                MessageBox.Show("Player details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a player to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPlayers.SelectedItem is Player selectedPlayer)
            {
                // Confirm deletion
                var confirmResult = MessageBox.Show($"Are you sure you want to delete {selectedPlayer.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Remove the player from the list
                    players.Remove(selectedPlayer);

                    // Refresh the ListBox
                    listBoxPlayers.DataSource = null;
                    listBoxPlayers.DataSource = players;
                    listBoxPlayers.DisplayMember = "Name";

                    // Clear the form fields
                    ClearForm();
                    pictureBoxPhoto.Image = null;
                    MessageBox.Show($"{selectedPlayer.Name} has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a player to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ClearForm()
        {
            textBoxName.Text = string.Empty;
            textBoxTeam.Text = string.Empty;
            textBoxPosition.Text = string.Empty;
            numericUpDownPoints.Value = 0;
            numericUpDownAssists.Value = 0;
            numericUpDownRebounds.Value = 0;
            numericUpDownSteals.Value = 0;
            textBoxPhotoPath.Text = string.Empty;

            // Clear the PictureBox image
            pictureBoxPhoto.Image = null;
            pictureBoxPhoto.Refresh();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPlayer = (Player)listBoxPlayers.SelectedItem;
            if (selectedPlayer != null)
            {
                textBoxName.Text = selectedPlayer.Name;
                textBoxTeam.Text = selectedPlayer.Team;
                textBoxPhotoPath.Text = selectedPlayer.PhotoPath;
                textBoxPosition.Text = selectedPlayer.Position;
                numericUpDownPoints.Value = selectedPlayer.Points;
                numericUpDownAssists.Value = selectedPlayer.Assists;
                numericUpDownRebounds.Value = selectedPlayer.Rebounds;
                numericUpDownSteals.Value = selectedPlayer.Steals;
                pictureBoxPhoto.ImageLocation = selectedPlayer.PhotoPath;
                
            }
        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();
            pictureBoxPhoto.Refresh();

        }
    }
}
