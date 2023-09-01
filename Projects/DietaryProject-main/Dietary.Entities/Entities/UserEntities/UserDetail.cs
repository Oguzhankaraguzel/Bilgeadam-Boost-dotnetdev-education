using Dietary.Entities.Entities.EnumEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dietary.Entities.Entities.UserEntities
{
    public class UserDetail
    {
        public UserDetail()
        {
            Meals = new HashSet<Meal>();
        }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int Age { get { return (DateTime.Now.Year - BirthDate.Year); } }
        public decimal Weigth { get; set; }
        public decimal Height { get; set; }

        public decimal BodyMassIndex
        {
            get { return Math.Round((Weigth / (Height * Height) * 10000), 2); }
        }

        public decimal BMR
        {
            get
            {
                if (GenderId == 3)
                {
                    return 655.1m + (9.563m * Weigth) + (1.850m * Height) - (4.676m * Age);
                }
                else if (GenderId == 2)
                {
                    return 66.47m + (13.75m * Weigth) + (5.003m * Height) - (6.755m * Age);
                }
                else
                {
                    return (655.1m + (9.563m * Weigth) + (1.850m * Height) - (4.676m * Age) + 66.47m + (13.75m * Weigth) + (5.003m * Height) - (6.755m * Age)) / 2;
                }
            }

        }

        public decimal AMR
        {
            get
            {
                if (ActivityLevelId == 1)
                {
                    return BMR * 1.2m;
                }
                else if (ActivityLevelId == 2)
                {
                    return BMR * 1.375m;
                }
                else if (ActivityLevelId == 3)
                {
                    return BMR * 1.55m;
                }
                else if (ActivityLevelId == 4)
                {
                    return BMR * 1.725m;
                }
                else if (ActivityLevelId == 5)
                {
                    return BMR * 1.9m;
                }
                else
                {
                    return 0;
                }
            }

        }

        public int ActivityLevelId { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public string? PhotoPath { get; set; }
        public byte[]? Photo { get; set; }
        [ForeignKey(nameof(Diet))]
        public int DietId { get; set; }
        [ForeignKey(nameof(Goal))]
        public int GoalId { get; set; }
        [ForeignKey(nameof(Gender))]
        public int GenderId { get; set; }
        public User User { get; set; }
        public Diet Diet { get; set; }
        public Goal Goal { get; set; }
        public Gender Gender { get; set; }
        public ICollection<Meal> Meals { get; set; }

    }
}

