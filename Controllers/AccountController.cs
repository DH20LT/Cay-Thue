﻿using Microsoft.AspNetCore.Mvc;

namespace CayThue.Controllers;

/*
 * Manage Accounts to sell
 */
public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult AccountList()
    {
        return View();
    }
}