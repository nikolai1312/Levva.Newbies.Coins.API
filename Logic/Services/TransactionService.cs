using AutoMapper;
using Levva.Newbies.Coins.API.Data.Interfaces;
using Levva.Newbies.Coins.API.Domain.Models;
using Levva.Newbies.Coins.API.Logic.Dtos;
using Levva.Newbies.Coins.API.Logic.Interfaces;

namespace Levva.Newbies.Coins.API.Logic.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly IMapper _mapper;

        public TransactionService(ITransactionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TransactionDto Create(int userId, NewTransactionDto transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);
            _transaction.UserId = userId;
            _transaction.CreatedAt = DateTime.Now;
            var _newTransaction = _repository.Create(_transaction);
            return _mapper.Map<TransactionDto>(_newTransaction);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public TransactionDto Get(int id)
        {
            var _transaction = _mapper.Map<TransactionDto>(_repository.Get(id));
            return _transaction;
        }

        public List<TransactionDto> GetAll()
        {
            var _transaction = _mapper.Map<List<TransactionDto>>(_repository.GetAll());
            return _transaction;
        }

        public List<TransactionDto> SearchDescription(string query)
        {
            var _transactions = _repository.SearchByDescription(query);
            return _mapper.Map<List<TransactionDto>>(_transactions);
        }

        public void Update(TransactionDto transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);
            _repository.Update(_transaction);
        }
    }
}
