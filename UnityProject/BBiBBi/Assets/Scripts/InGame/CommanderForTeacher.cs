using System;
using System.Collections.Generic;

namespace ForTeacherBBiBBi
{
    public class CommanderForTeacher
    {
        private List<CommandEnum> theFinalCommandInstruction;
        public CommanderForTeacher() { }

        public void AMagicCommandMixingMachineForStudents(Int32 howManyCommands)
        {
            Random magicalCommandGenerator = new Random();

            theFinalCommandInstruction = new List<CommandEnum>();
            for (Int32 i = 0; i < howManyCommands; i++)
            {
                theFinalCommandInstruction.Add(
                    (CommandEnum)magicalCommandGenerator.Next(0, (Int32)CommandEnum.End - 1));
            }
        }

        public List<CommandEnum> GetTheFinalCommandInstruction() { return theFinalCommandInstruction; }
    }

}