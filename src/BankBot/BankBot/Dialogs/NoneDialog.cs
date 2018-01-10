﻿using BankBot.BLL;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BankBot.Dialogs
{
    public partial class RootDialog
    {
        [LuisIntent("None")]
        public async Task GetNoneMessage(IDialogContext context, LuisResult result)
        {
            string message = new OthersManager().GetCommonMessage();
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }
    }
}