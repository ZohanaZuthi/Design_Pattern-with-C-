using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace State_patterns
{
    public class Document
    {
        public DocumentStates State { get; set; }
        public UserRoles CurrentUserRole { get; set; }
        public void Publish()
        {
            if (State == DocumentStates.Draft)
            {
                State = DocuentStates.Moderation;
            }
            else if (State == DocumentStates.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentStates.Published;
                }
            }
            else if (State == DocumentStates.Published) { }
        }

    }
}