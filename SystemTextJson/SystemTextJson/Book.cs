////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project: SystemTextJson
// File Name: Book.cs
// Description: To represent json file 
// Course: CSCI-2910-940
// Author: Sydni Ward
// Created: 11/14/2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;

namespace SystemTextJson
{
    class Book
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public IList<Items> items { get; set; }
    }
}