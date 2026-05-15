using MediatR;
using MyApp.Application.Interfaces;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.Commands
{
    public record UpdateStudentCommand(int id, Student Student) : IRequest<Student>;
    public class UpdateStudentCommandHandler(IStudentRepository studentRepository) : IRequestHandler<UpdateStudentCommand, Student>
    {
        public async Task<Student> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            return await studentRepository.UpdateStudentAsync(request.id, request.Student);
        }
    }
}
    