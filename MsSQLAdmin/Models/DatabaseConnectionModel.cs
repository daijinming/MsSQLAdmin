using System.ComponentModel.DataAnnotations;

namespace MsSQLAdmin.Models {
    public class DatabaseConnectionModel {
        [Required]
        [Display(Name = "服务器 : ")]
        public string Server { get; set; }
        [Display(Name = "数据库 : ")]
        public string Database { get; set; }
        [Display(Name = "帐号 : ")]
        public string Username { get; set; }
        [Display(Name = "密码 : ")]
        public string Password { get; set; }
        [Display(Name = "连接类型 : ")]
        public bool IsWindows { get; set; }

        public string ConnectionString => this.IsWindows ? this.ConnectionStringWindows : this.ConnectionStringUserPwd;
        public string ConnectionStringUserPwd => $"Server={this.Server};Database={this.Database};User Id={this.Username};Password={this.Password};";
        public string ConnectionStringWindows => $"Server={this.Server};Database={this.Database};Trusted_Connection=True;";
    }
}