﻿using Ardalis.Specification;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Application.Contracts.Repositories;

/// <summary>
/// Question Sections repository interface
/// </summary>
public interface IQuestionSectionsRepository
{

    /// <summary>
    /// Gets all questions using the provided specification
    /// </summary>
    Task<IEnumerable<QuestionSection>> GetQuestionSections();

    /// <summary>
    /// Gets all questions using the provided specification
    /// </summary>
    Task<QuestionSection?> GetNextQuestionSection(string sectionId);

    /// <summary>
    /// Gets all questions using the provided specification
    /// </summary>
    Task<QuestionSection?> GetPreviousQuestionSection(string sectionId);
}