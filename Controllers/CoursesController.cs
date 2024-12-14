﻿using CodigoSistClases.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodigoSistClases.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public List<Course> Get()
        {
            using (var context = new DemoContext())
            {
                return context.Courses.ToList();
            }
        }

        [HttpPost]
        public void Insert(Course _course)
        {
            using (var context = new DemoContext())
            {
                context.Courses.Add(_course);
                context.SaveChanges();
            }
        }

        [HttpPut]
        public void Update(Course _course)
        {
            using (var context = new DemoContext())
            {
                context.Entry(_course).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        [HttpDelete]
        public void Delete(int CourseId)
        {
            using (var context = new DemoContext())
            {
                var course = context.Courses.Find(CourseId);
                context.Courses.Remove(course);
                context.SaveChanges();
            }
        }
    }
}