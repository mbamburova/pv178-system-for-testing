using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL.DTOs;

namespace WEB.Models {
    public class QuestionViewModel {

        public List<QuestionDTO> Questions { get; set; }

        public int ThematicFieldId { get; set; }

        public QuestionViewModel() {
            Questions = new List<QuestionDTO>();
        }
    }
}