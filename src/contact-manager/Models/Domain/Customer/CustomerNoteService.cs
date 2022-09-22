using contact_manager.Models.Data;

namespace contact_manager.Models.Domain
{
    internal class CustomerNoteService : ICustomerNoteService
    {
        private readonly IRepository<CustomerNote> _customerNoteRepository;

        public CustomerNoteService(IRepository<CustomerNote> customerNoteRepository)
        {
            this._customerNoteRepository = customerNoteRepository;
        }

        public List<CustomerNote> LoadAllNotesByCustomerId(long customerId)
        {
            var notes = this._customerNoteRepository.GetAll();
            return notes.FindAll(n => n.CustomerId == customerId);
        }

        public void CreateNewNote(long customerId, string text, string createdBy)
        {
            var note = new CustomerNote
            {
                Id = this._customerNoteRepository.GetNewId(),
                CustomerId = customerId,
                Text = text,
                CreatedBy = createdBy,
                CreatedAt = DateTime.Now
            };
            this._customerNoteRepository.Save(note);
        }

        public void DeleteNotes(long customerId)
        {
            var notesByCustomer = this._customerNoteRepository.GetAll().FindAll(n => n.CustomerId == customerId);
            foreach (var note in notesByCustomer)
            {
                this._customerNoteRepository.Delete(note.Id);
            }
        }
    }
}
