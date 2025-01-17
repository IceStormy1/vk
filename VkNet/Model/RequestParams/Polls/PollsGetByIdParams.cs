﻿using System;

namespace VkNet.Model.RequestParams;

/// <summary>
/// Список параметров для метода polls.getById
/// </summary>
[Serializable]
public class PollsGetByIdParams
{
	/// <summary>
	/// Идентификатор владельца опроса.
	/// </summary>
	public long? OwnerId { get; set; }

	/// <summary>
	/// True — опрос находится в обсуждении, False — опрос прикреплен к стене.
	/// По умолчанию — False.
	/// </summary>
	public bool? IsBoard { get; set; }

	/// <summary>
	/// Идентификатор опроса.
	/// </summary>
	public long PollId { get; set; }
}