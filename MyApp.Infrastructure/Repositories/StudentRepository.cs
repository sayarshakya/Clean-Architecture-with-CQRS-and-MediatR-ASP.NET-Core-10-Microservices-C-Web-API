using Microsoft.EntityFrameworkCore;
using MyApp.Application.Interfaces;
using MyApp.Domain.Entities;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Infrastructure.Repositories
{
    public class StudentRepository(ApplicationDbContext context) : IStudentRepository
    {
        public async Task<IEnumerable<Student>> GetAllStudentsAsync()
        {
            return await context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            return await context.Students.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> UpdateStudentAsync(int id, Student student)
        {
            var existingStudent = await context.Students.FirstOrDefaultAsync(x => x.Id == id);

            if (existingStudent is not null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Class = student.Class;
                existingStudent.FatherName = student.FatherName;
                existingStudent.MotherName = student.MotherName;
                context.Students.Update(existingStudent);
            }
            await context.SaveChangesAsync();
            return student;
        }

        public async Task<string> DeleteStudentAsync(int id)
        {
            var existingStudent = await context.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (existingStudent is not null)
            {
                context.Students.Remove(existingStudent);
                await context.SaveChangesAsync();
                return "Student deleted successfully.";
            }

            return "Student not found.";
        }
    }
}
