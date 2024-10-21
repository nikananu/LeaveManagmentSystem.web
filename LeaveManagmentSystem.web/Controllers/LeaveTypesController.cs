using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagmentSystem.web.Data;
using LeaveManagmentSystem.web.Models.LeaveTypes;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LeaveManagmentSystem.web.Services;

namespace LeaveManagmentSystem.web.Controllers
{
    public class LeaveTypesController(ILeaveTypeServices _leaveTypeServices) : Controller
    {
        
        



        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
          var viewData= await _leaveTypeServices.GetAllLeaveTypes();
          
            return View(viewData);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypeServices.Get<LeaveTypeReadOnlyVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }
            

            return View(leaveType);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeCreateVM leaveTypeCreate)
        { if(await _leaveTypeServices.CheckIfLeaveTypeExists(leaveTypeCreate.name))
            {
                ModelState.AddModelError(nameof(leaveTypeCreate.name), "This Leave Type Already Exist In The Database");
            }



            if (ModelState.IsValid)
            {
                _leaveTypeServices.Create(leaveTypeCreate);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeCreate);
        }

        

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypeServices.Get<LeaveTypeEditVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }


            return View(leaveType);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeEditVM leaveTypeEdit)
        {
            
            if (id != leaveTypeEdit.Id)
            {
                return NotFound();
            }
            if (await _leaveTypeServices.CheckIfLeaveTypeExistsForEdit(leaveTypeEdit) )
            {
                ModelState.AddModelError(nameof(leaveTypeEdit.name), "This Leave Type Already Exist In The Database");
            }


            if (ModelState.IsValid)
            {
                try
                {
                    _leaveTypeServices.Edit(leaveTypeEdit);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_leaveTypeServices.LeaveTypeExists(leaveTypeEdit.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeEdit);
        }

        

        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypeServices.Get<LeaveTypeReadOnlyVM>(id.Value);
            if (leaveType == null)
            {
                return NotFound();
            }

            return View(leaveType);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _leaveTypeServices.Remove(id);


            return RedirectToAction(nameof(Index));
        }

   
    }
}
