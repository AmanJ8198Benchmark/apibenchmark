using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentApi.DTOS;
using StudentApi.Models;
using StudentApi.Repository;

namespace StudentApi.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _repository;
        private readonly IMapper _mapper;
        public StudentController(IStudent repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StudentReadDto>> GetStudents()
        {
            var studentItem = _repository.GetStudents();
            return Ok(_mapper.Map<IEnumerable<StudentReadDto>>(studentItem));
        }
        [HttpGet("{id}",Name ="GetStudentById")]
        public ActionResult<StudentReadDto> GetStudentById(int id)
        {
            var studentItem = _repository.GetStudentById(id);
            if(studentItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<StudentReadDto>(studentItem));
            
        }
        [HttpPost]
        public ActionResult<StudentReadDto> CreateStudent(StudentCreateDto studentCreateDto)
        {
            var studentModel = _mapper.Map<Student>(studentCreateDto);
            _repository.CreateStudent(studentModel);
            _repository.SaveChanges();
            var studentReadDto = _mapper.Map<StudentReadDto>(studentModel);
            return CreatedAtRoute(nameof(GetStudentById), new { Id = studentReadDto.StudentId }, studentReadDto);
        }
        [HttpPut]
        public ActionResult UpdateStudent(int id, StudentUpdateDto studentUpdateDto)
        {
            var studentModelFromRepo = _repository.GetStudentById(id);
            if(studentModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(studentUpdateDto, studentModelFromRepo);
            _repository.UpdateStudent(studentModelFromRepo);
            _repository.SaveChanges();
            return NoContent();

        }
        [HttpDelete]
        public ActionResult DeleteStudent(int id)
        {
            var studentModelFromRepo = _repository.GetStudentById(id);
            if (studentModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.DeleteStudent(studentModelFromRepo);
            _repository.SaveChanges();
            return NoContent();


        }
    }
}
