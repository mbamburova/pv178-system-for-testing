using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL.DTOs;

namespace WEB.Models {
    public class AnswerEditViewModel {

        public AnswerDTO Answer { get; set; }

        public int QuestionId { get; set; }
           
    }
}