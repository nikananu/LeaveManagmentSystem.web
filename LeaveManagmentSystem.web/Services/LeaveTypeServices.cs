using AutoMapper;
using LeaveManagmentSystem.web.Data;
using LeaveManagmentSystem.web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagmentSystem.web.Services;

public class LeaveTypeServices(ApplicationDbContext context, IMapper mapper) : ILeaveTypeServices
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public async Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes()
    {
        var data = await _context.LeaveTypes.ToListAsync();
        var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
        return viewData;
    }

    public async Task<T?> Get<T>(int id) where T : class
    {
        var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
        if (leaveType == null)
        {
            return null;
        }
        var viewData = _mapper.Map<T>(leaveType);

        return viewData;

    }
    public async Task Remove(int id)
    {
        var leaveType = await _context.LeaveTypes
                .FirstOrDefaultAsync(m => m.Id == id);
        if (leaveType != null)
        {
            _context.Remove(leaveType);
            await _context.SaveChangesAsync();
        }

    }

    public async Task Edit(LeaveTypeEditVM model)
    {
        var viewData = _mapper.Map<LeaveType>(model);
        _context.Update(viewData);
        await _context.SaveChangesAsync();


    }

    public async Task Create(LeaveTypeCreateVM model)
    {
        var leaveType = _mapper.Map<LeaveType>(model);
        _context.Add(leaveType);
        await _context.SaveChangesAsync();

    }
    private bool LeaveTypeExists(int id)
    {
        return _context.LeaveTypes.Any(e => e.Id == id);
    }
    private async Task<bool> CheckIfLeaveTypeExists(string name)
    {
        var lowercaseName = name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.name.ToLower().Equals(lowercaseName));
    }
    private async Task<bool> CheckIfLeaveTypeExistsForEdit(LeaveTypeEditVM leaveTypeEdit)
    {
        var lowercaseName = leaveTypeEdit.name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.name.ToLower().Equals(lowercaseName)
        && q.Id != leaveTypeEdit.Id
        );
    }

}


