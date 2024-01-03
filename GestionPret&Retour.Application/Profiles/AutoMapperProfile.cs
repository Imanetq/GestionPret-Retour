using AutoMapper;
using GestionPret_Retour.Application.Loans.Dommands.CreateLoan;
using GestionPret_Retour.Application.Loans.ViewModel;
using GestionPret_Retour.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionPret_Retour.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book,BookViewModel>().ReverseMap();
            CreateMap<Loan, FindLoanViewModel>().ReverseMap(); 
            CreateMap<Loan,CreateLoanCommand>().ReverseMap();
            CreateMap<User, CreateUserViewModel>().ReverseMap();
            CreateMap<Book, BookViewModel>().ReverseMap();


        }
    }
}
