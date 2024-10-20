﻿using Entites.Data;
using Repositories.Interfaces;


namespace Repositories.Impelmentations
{
    public sealed class RepositoryManger : IRepositoryManger
    {
        private readonly ElearingDbcontext _context;
        private readonly Lazy<ICourseRepository> _courseRepository;
        private readonly Lazy<IModuleRepository> _moduleRepository;
        private readonly Lazy<ILessonRepository> _lessonRepository;
        private readonly Lazy<IMaterialRepository> _materialRepository; 
        private readonly Lazy<IProgressRepository> _progressRepository;
        private readonly Lazy<INoteRepository> _noteRepository;
        private readonly Lazy<IPaymentRepository> _paymentRepository;
        private readonly Lazy<IQuestionRepository> _questionRepository;

        public RepositoryManger(ElearingDbcontext context)
        {
            _context = context;
            _courseRepository=new Lazy<ICourseRepository>(()=>
                new CourseRepository(context));
            _moduleRepository=new Lazy<IModuleRepository>(()=> 
            new ModuleRepository(context));
            _lessonRepository=new Lazy<ILessonRepository>(()=>
            new LessonRepository(context));
            _materialRepository=new Lazy<IMaterialRepository>(()=>
            new MaterialRepository(context));
            _progressRepository=new Lazy<IProgressRepository>(()=>
            new ProgressRepository(context));
            _noteRepository=new Lazy<INoteRepository>(()=>
            new NoteRepository(context));
            _paymentRepository=new Lazy<IPaymentRepository>(()=>
            new PaymentRepository(context));
            _questionRepository=new Lazy<IQuestionRepository>(()=>
            new QuestionRepository(context));

        }
        public ICourseRepository courseRepository => _courseRepository.Value;

		public IModuleRepository moduleRepository => _moduleRepository.Value;

        public ILessonRepository lessonRepository => _lessonRepository.Value;

        public IMaterialRepository materialRepository =>_materialRepository.Value;

		public IProgressRepository progressRepository =>_progressRepository.Value;

        public INoteRepository noteRepository => _noteRepository.Value;

        public IPaymentRepository paymentRepository => _paymentRepository.Value;
        public IQuestionRepository questionRepository => _questionRepository.Value;

        public async Task Save()
        {
           await _context.SaveChangesAsync();
        }
    }
}
