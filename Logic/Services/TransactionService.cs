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

        public Transaction Create(Transaction transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);
            _repository.Create(_transaction);
            return _transaction;
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

        public void Update(TransactionDto transaction)
        {
            var _transaction = _mapper.Map<Transaction>(transaction);
            _repository.Update(_transaction);
        }
    }
}
