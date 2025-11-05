using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_MySQL
{

    public class Exam_Service
    {
        private readonly Exam_repository repo = new Exam_repository();

        public void Register(Exam exam)
        {
            if (string.IsNullOrWhiteSpace(exam.Name))
            {
                throw new ArgumentException("이름은 반드시 입력해야합니다.");
            }
            repo.AddExam(exam);
        }

        public List<Exam> GetAllRegisteredExams(string name, string phone)
        {
            // 1. Service Layer의 로직: 입력된 검색 조건이 모두 비어있는지 확인
            if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(phone))
            {
                // 모두 비어있다면, 기존의 전체 조회 메서드를 호출합니다.
                // (Repository의 getAllExams()와 동일한 결과를 반환)
                return repo.getAllExams();
            }

            // 2. Repository 호출: 하나라도 검색 조건이 있다면, 
            // Repository의 필터링 메서드에 조건을 전달합니다.
            return repo.GetFilteredExams(name, phone);
        }

        public List<Exam> GetAllRegisterExams()
        {
            return repo.getAllExams();
        }

        public void Update(Exam exam) 
        {
            if (exam.Id <= 0)
            {
                throw new ArgumentException("유효하지 않은 ID로 업데이트 시도했습니다.");
            }
            repo.UpdateExam(exam);
        }

        public void Delete(int Id) 
        {
            repo.DeleteExam(Id);
        }
    }
}
