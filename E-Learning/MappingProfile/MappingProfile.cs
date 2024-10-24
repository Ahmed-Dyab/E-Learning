﻿using AutoMapper;
using Entites.Models;
using Enities.ViweModel.Course;
using Enities.ViweModel.Module;
using Enities.ViweModel.Lesson;
using Enities.ViweModel.Material;
using Enities.ViweModel.Progress;
using Enities.ViweModel;
using Enities.ViweModel.User;
using Enities.ViweModel.Note;
using Entites.ViewModel.User;
using Enities.ViweModel.Anouncment;
using Enities.ViweModel.Question;
using Enities.ViweModel.AnswerVM;
namespace E_Learning.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, GetCourseVM>().ReverseMap();
            CreateMap<Course, CreateorUpdateCourseVM>().ReverseMap();
            CreateMap<Module,CreateorUpdateModuleVM>().ReverseMap();
            CreateMap<Module,GetModuleVM>().ReverseMap();   
            CreateMap<Lesson,CreateorUpdateLessonVM>().ReverseMap();
            CreateMap<Lesson,GetLessonVM>().ReverseMap();
            CreateMap<Material, GetMaterialsVM>().ReverseMap();
            CreateMap<Progress, CreateProgressVM>().ReverseMap();
            CreateMap<Progress, GetProgressVM>().ReverseMap();
			//CreateMap<User, LoginVM>().ReverseMap();
			CreateMap<User, LoginVM>().ReverseMap();
            CreateMap<Note, GetNoteVM>().ReverseMap();
            CreateMap<Note, CreateNoteVM>().ReverseMap();
            CreateMap<Note, UpdateNoteVM>().ReverseMap();
            CreateMap<Anouncment, GetAnouncmentForStudentVM>().ReverseMap();
            CreateMap<Question, GetQuestionVM>().ReverseMap();
            CreateMap<Question, CreateQuestionVM>().ReverseMap();
            CreateMap<Question, UpdateQuestionVM>().ReverseMap();
            CreateMap<Answer, CreateAnswerVM>().ReverseMap();

		}
    }
}
