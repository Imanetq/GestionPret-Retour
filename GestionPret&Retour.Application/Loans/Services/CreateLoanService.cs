using AutoMapper;
using GestionPret_Retour.Application.Contracts;
using GestionPret_Retour.Application.Loans.Dommands.CreateLoan;
using GestionPret_Retour.Application.Loans.ViewModel;
using GestionPret_Retour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Loans.Services
{
    public class CreateLoanService : ICreateLoanService
    {
        private readonly IMapper _mapper;
        private readonly ILoanRepository _loanRepository;
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        public CreateLoanService(ILoanRepository loanRepository, IMapper mapper, IUserRepository userRepository,IBookRepository bookRepository)
        {
            _loanRepository = loanRepository;
            _mapper = mapper;
            _userRepository = userRepository;
            _bookRepository = bookRepository;

        }
        public async Task<int> CreateLoan(CreateLoanCommand request)
        {
            User user = await _userRepository.GetByIdAsync(request.UserId);
            if(user == null)
            {
                var newUser = new CreateUserViewModel(request.UserId, false, 0);
                User userNew = _mapper.Map<User>(newUser);
                await _userRepository.AddAsync(userNew);

            }
            
            //CreateCommandValidator validator = new CreateCommandValidator();
            //var result = await validator.ValidateAsync(request);
            //if (result.Errors.Any())
            //{
            //    throw new Exception("Post is not valid");
            //}
            //foreach(var book in request.Books) {
            //    var bookViewModel = new BookViewModel(book.Id, book.Quantity, book.LoanId);
            //    var mapbook = _mapper.Map<Book>(bookViewModel);
            //    await _bookRepository.AddAsync(mapbook);
            //}
            Loan loan = _mapper.Map<Loan>(request);
            loan = await _loanRepository.AddAsync(loan);
            return loan.LoanId;
        }
    }
}
