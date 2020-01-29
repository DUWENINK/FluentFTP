﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FluentFTP {

	/// <summary>
	/// Stores the result of a file transfer when UploadDirectory or DownloadDirectory is used.
	/// </summary>
	public class FtpFileResult {

		/// <summary>
		/// Gets the name and extension of the file.
		/// </summary>
		public string Name;

		/// <summary>
		/// Stores the absolute remote path of the the current file being transfered.
		/// </summary>
		public string RemotePath { get; set; }

		/// <summary>
		/// Stores the absolute local path of the the current file being transfered.
		/// </summary>
		public string LocalPath { get; set; }

		/// <summary>
		/// Gets the error that occuring during transfering this file, if any.
		/// </summary>
		public Exception Exception;

		/// <summary>
		/// Returns true if the file was downloaded/uploaded, or the file was already existing with the same file size.
		/// </summary>
		public bool IsSuccess;

		/// <summary>
		/// Was the file skipped?
		/// </summary>
		public bool IsSkipped;
		
		/// <summary>
		/// Was there an error during transfer?
		/// </summary>
		public bool IsFailed;

	}
}