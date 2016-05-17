using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL.DTOs;
using BL.Repositories;

namespace WEB.Models {
    public class AnswerViewModel {

        public List<AnswerDTO> Answers { get; set; }
        
        public int QuestionId { get; set; }

        public AnswerViewModel() {
            Answers = new List<AnswerDTO>();
        }
    }
}