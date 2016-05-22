using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL.DTOs;

namespace WEB.Models {
    public class TestPrefaceViewModel {

        public List<TestPrefaceDTO> TestPrefaces { get; set; }

        public TestPrefaceViewModel() {
            TestPrefaces = new List<TestPrefaceDTO>();
        } 
    }
}