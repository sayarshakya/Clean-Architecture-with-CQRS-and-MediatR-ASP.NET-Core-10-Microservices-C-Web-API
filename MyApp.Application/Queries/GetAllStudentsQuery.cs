using MediatR;
using MyApp.Application.Interfaces;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.Queries
{
    public record GetAllStudentsQuery() : IRequest<IEnumerable<Student>>;
    public class GetAllStudentsQueryHandler(IStudentRepository studentRepository) : IRequestHandler<GetAllStudentsQuery, IEnumerable<Student>>
    {
        public Task<IEnumerable<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            return studentRepository.GetAllStudentsAsync();
        }
    }
}
