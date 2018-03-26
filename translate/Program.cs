﻿// Copyright (c) 2018 Google LLC.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License. You may obtain a copy of
// the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations under
// the License.

using System;
using Google.Cloud.Translation.V2;

namespace translate
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = TranslationClient.Create();
            foreach (var language in client.ListLanguages("en"))
            {
                Console.WriteLine($"{language.Code}: {language.Name}");
            }
            var result = client.TranslateText("Hello world.", "ms", "en");
            Console.WriteLine(result.TranslatedText);
        }
    }
}