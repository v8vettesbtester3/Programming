using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Reflection.Emit;

namespace MagicPotions
{
    public partial class MainForm : Form
    {
        // List to store potions, each represented as a dictionary
        private List<Dictionary<string, object>> potions = new List<Dictionary<string, object>>();
        private Random random = new Random(); // Random object for generating random potions

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddPotion_Click(object sender, EventArgs e)
        {
            string name = txtPotionNameInput.Text; // Get potion name from input
            string[] ingredients = txtIngredientsInput.Text.Split(','); // Split ingredients by comma
            string effect = txtEffectInput.Text; // Get potion effect from input
                                                 // Validate potency input
            if (!int.TryParse(txtPotencyInput.Text, out int potency) || potency < 1 || potency > 10)
            {
                lblStatusMessage.Text = "Invalid potency level. Please enter a number between 1 and 10.";
                return;
            }
            // Create a dictionary for the potion with its properties
            var potion = new Dictionary<string, object>
            {
                { "PotionName", name },
                { "Ingredients", ingredients.Select(i => i.Trim()).ToList() }, // Trim whitespace from each ingredient
                { "Effect", effect },
                { "Potency", potency }
            };
            // Add potion to the list
            potions.Add(potion);
            lblStatusMessage.Text = "Potion added successfully!"; // Update status label
            DisplayPotions(); // Refresh displayed potions
            ClearInputs(); // Clear input fields
        }

        private void btnRemovePotion_Click(object sender, EventArgs e)
        {
            string name = txtPotionNameInput.Text; // Get potion name from input
                                                   // Find the potion by name
            var potion = potions.FirstOrDefault(p => (string)p["PotionName"] == name);
            if (potion != null)
            {
                potions.Remove(potion); // Remove potion from the list
                lblStatusMessage.Text = "Potion removed successfully!"; // Update status label
                DisplayPotions(); // Refresh displayed potions
            }
            else
            {
                lblStatusMessage.Text = "Potion not found."; // Display error if potion doesn't exist
            }
            ClearInputs(); // Clear input fields
        }

        private void btnExperimentPotion_Click(object sender, EventArgs e)
        {
            string name = txtPotionNameInput.Text; // Get potion name from input
                                                   // Find the potion by name
            var potion = potions.FirstOrDefault(p => (string)p["PotionName"] == name);
            if (potion != null)
            {
                // Update ingredients
                potion["Ingredients"] = txtIngredientsInput.Text.Split(',').Select(i =>
                i.Trim()).ToList();
                // Update potency and validate
                if (int.TryParse(txtPotencyInput.Text, out int newPotency) && newPotency >= 1 &&
                newPotency <= 10)
                {
                    potion["Potency"] = newPotency;
                    lblStatusMessage.Text = "Potion updated successfully!"; // Update status label
                    DisplayPotions(); // Refresh displayed potions
                }
                else
                {
                    lblStatusMessage.Text = "Invalid potency level."; // Display error if potency is invalid
                }
            }
            else
            {
                lblStatusMessage.Text = "Potion not found."; // Display error if potion doesn't exist
            }
            ClearInputs(); // Clear input fields
        }

        private void btnSearchPotion_Click(object sender, EventArgs e)
        {
            string search = txtPotionNameInput.Text; // Get search term from input
                                                     // Find potions that match the name or contain the ingredient
            var results = potions.Where(p => (string)p["PotionName"] == search ||
            ((List<string>)p["Ingredients"]).Contains(search)).ToList();
            // Display matching potions or error if none found
            if (results.Any())
            {
                lstPotionDisplayList.Items.Clear(); // Clear the display list
                foreach (var potion in results)
                {
                    lstPotionDisplayList.Items.Add(DisplayPotionDetails(potion)); // Add each matching potion to display list
                }
                lblStatusMessage.Text = $"{results.Count} potion(s) found."; // Update status label with count of results
            }
            else
            {
                lblStatusMessage.Text = "No potions found."; // Display error if no potions match
            }
        }

        private void btnMysteryMix_Click(object sender, EventArgs e)
        {
            // Arrays of random names, effects, and ingredient options for the mystery potion
            string[] names = { "Potion of Strength", "Potion of Invisibility", "Elixir of Luck", "Tonic of Speed" };
            string[] effects = { "Boosts strength", "Grants invisibility", "Increases luck", "Enhances speed" };
            List<string[]> ingredientOptions = new List<string[]>
            {
                new string[] { "Unicorn Hair", "Goblin Dust", "Dragon Scale" },
                new string[] { "Phoenix Feather", "Witch's Brew", "Mermaid Tears" },
                new string[] { "Gnome Leaf", "Elf Root", "Magic Stones" }
            };
            // Create a new potion with random properties
            var randomPotion = new Dictionary<string, object>
            {
                { "PotionName", names[random.Next(names.Length)] },
                { "Ingredients", ingredientOptions[random.Next(ingredientOptions.Count)].ToList() },
                { "Effect", effects[random.Next(effects.Length)] },
                { "Potency", random.Next(1, 11) }
            };
            // Add the mystery potion to the list
            potions.Add(randomPotion);
            lblStatusMessage.Text = "A mysterious new potion has been brewed!"; // Update status label
            DisplayPotions(); // Refresh displayed potions
        }

        private void btnDisplayPotions_Click(object sender, EventArgs e)
        {
            DisplayPotions(); // Call method to refresh the display list with all potions
        }

        // Method to display all potions in the list
        private void DisplayPotions()
        {
            lstPotionDisplayList.Items.Clear(); // Clear current display list
                                                // Display each potion with details
            foreach (var potion in potions)
            {
                lstPotionDisplayList.Items.Add(DisplayPotionDetails(potion)); // Add potion details to display list
            }
        }
        // Helper method to format and return potion details as a string
        private string DisplayPotionDetails(Dictionary<string, object> potion)
        {
            string name = (string)potion["PotionName"];
            string ingredients = string.Join(", ", (List<string>)potion["Ingredients"]);
            string effect = (string)potion["Effect"];
            int potency = (int)potion["Potency"];
            return $"Name: {name}, Ingredients: {ingredients}, Effect: {effect}, Potency: {potency}"; // Format potion details
        }
        // Helper method to clear input fields after an operation
        private void ClearInputs()
        {
            txtPotionNameInput.Clear();
            txtIngredientsInput.Clear();
            txtEffectInput.Clear();
            txtPotencyInput.Clear();
        }
    }
}
