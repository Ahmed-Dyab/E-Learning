﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.ViweModel.Lesson
{
    public class GetLessonVM
    {
		public int Id { get; set; }
		public string Title { get; set; }
        public bool IsChecked {  get; set; }=false;
    }
}
