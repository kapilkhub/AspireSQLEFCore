﻿using Microsoft.EntityFrameworkCore;

namespace AspireSQLEFCore;

public class TicketContext(DbContextOptions options) : DbContext(options)
{
	public DbSet<SupportTicket> Tickets => Set<SupportTicket>();
}