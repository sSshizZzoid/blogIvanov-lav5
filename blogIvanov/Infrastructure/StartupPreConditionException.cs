﻿using blogIvanov.Domain.DB;
using blogIvanov.Infrastructure.Guarantors;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace blogIvanov.Infrastructure
{
    /// <summary>
    /// Исключение, вызванное неправилньой средой запуска приложения
    /// Дальнешее выполнение невозможно
    /// </summary>
    public class StartupPreConditionException : Exception
    {
        /// <summary>
        /// Создание экземпляра класса <seealso cref="StartupPreConditionException"/>
        /// </summary>
        /// <param name="message">Сообщение</param>
        public StartupPreConditionException(string message) : base(message)
        {
        }
    }
}