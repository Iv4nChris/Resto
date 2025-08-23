using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    public partial class ContactForm : ComponentBase
    {
        private ContactModel contactModel = new ContactModel();

        private void HandleSubmit()
        {
            // Here you can integrate email API or form submission logic
            Console.WriteLine($"Name: {contactModel.Name}, Email: {contactModel.Email}, Message: {contactModel.Message}");
        }

        private class ContactModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }
        }
    }
}
