using AutoMapper;
using LeaveManagmentSystem.web.Data;
using LeaveManagmentSystem.web.Models.LeaveTypes;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagmentSystem.web.Services;

public class LeaveTypeServices(ApplicationDbContext _context, IMapper _mapper) : ILeaveTypeServices
{
    

    public async Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes()
    {
        var data = await _context.LeaveTypes.ToListAsync();
        var viewData1 = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
        return viewData1;
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
    public bool LeaveTypeExists(int id)
    {
        return _context.LeaveTypes.Any(e => e.Id == id);
    }
    public async Task<bool> CheckIfLeaveTypeExists(string name)
    {
        var lowercaseName = name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.name.ToLower().Equals(lowercaseName));
    }
    public async Task<bool> CheckIfLeaveTypeExistsForEdit(LeaveTypeEditVM leaveTypeEdit)
    {
        var lowercaseName = leaveTypeEdit.name.ToLower();
        return await _context.LeaveTypes.AnyAsync(q => q.name.ToLower().Equals(lowercaseName)
        && q.Id != leaveTypeEdit.Id
        );
    }

}


