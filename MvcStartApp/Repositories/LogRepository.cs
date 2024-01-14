using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc;

namespace MvcStartApp.Repositories
{
    public class LogRepository : ILogRepository
    {
        // ссылка на контекст
        private readonly BlogContext _context;

        // Метод-конструктор для инициализации
        public LogRepository(BlogContext context)
        {
            _context = context;
        }

        public async Task AddLog(Request request)
        {
            // Добавление реквеста-лога в таблицу БД
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.Requests.AddAsync(request);

            // Сохранение изенений
            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetLogs()
        {
            // Получим все логи
            return await _context.Requests.ToArrayAsync();
        }
    }
}
