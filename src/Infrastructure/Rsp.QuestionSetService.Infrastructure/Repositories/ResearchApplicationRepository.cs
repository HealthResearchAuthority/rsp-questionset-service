using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rsp.QuestionSetService.Application.Contracts.Repositories;
using Rsp.QuestionSetService.Domain.Entities;

namespace Rsp.QuestionSetService.Infrastructure.Repositories;

public class ResearchApplicationRepository(QuestionSetDbContext context) : IResearchApplicationRepository
{
    private readonly QuestionSetDbContext _context = context;

    public async Task<ResearchApplication?> GetApplication(ISpecification<ResearchApplication> specification)
    {
        return await _context
            .ResearchApplications
            .WithSpecification(specification)
            .FirstOrDefaultAsync();
    }

    public Task<IEnumerable<ResearchApplication>> GetApplications(ISpecification<ResearchApplication> specification)
    {
        var result = _context
            .ResearchApplications
            .WithSpecification(specification)
            .AsEnumerable();

        return Task.FromResult(result);
    }

    public async Task<ResearchApplication> CreateApplication(ResearchApplication application)
    {
        var entity = await _context.ResearchApplications.AddAsync(application);

        await _context.SaveChangesAsync();

        return entity.Entity;
    }

    public async Task<ResearchApplication?> UpdateApplication(ResearchApplication application)
    {
        var entity = await _context.ResearchApplications
            .FirstOrDefaultAsync(record => record.ApplicationId == application.ApplicationId);

        if (entity != null)
        {
            entity.Title = application.Title;
            entity.Status = application.Status;
            entity.Description = application.Description;
            entity.IsActive = application.IsActive;
            entity.UpdatedBy = application.UpdatedBy;
            entity.UpdatedDate = application.UpdatedDate;

            await _context.SaveChangesAsync();

            return entity;
        }

        return default;
    }

    public async Task DeleteApplication(string applicationId)
    {
        var entity = await _context.ResearchApplications
            .FirstOrDefaultAsync(record => record.ApplicationId == applicationId);

        if (entity != null)
        {
            _context.ResearchApplications.Remove(entity);

            await _context.SaveChangesAsync();
        }
    }

    public async Task SaveRespondent(Respondent respondent)
    {
        await _context.Respondents.AddAsync(respondent);
        await _context.SaveChangesAsync();
    }

    public async Task SaveRespondentAnswers(IEnumerable<RespondentAnswer> answers)
    {
        await _context.RespondentAnswers.AddRangeAsync(answers);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<RespondentAnswer>> GetRespondentAnswers(string applicationId)
    {
        return await
            _context.RespondentAnswers
            .AsSplitQuery()
            .AsNoTracking()
            .Where(ra => ra.ApplicationId == applicationId)
            .ToListAsync();
    }
}