using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/27 
 * 이름 : 장혜영
 * 내용 : 데이터베이스 프로그래밍 실습
 */
namespace Ch10
{
    internal class _5_Select_실습
    {
        static void Main1(string[] args)
        {
            // 데이터베이스 정보
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";

            // 데이터베이스 커넥션 생성
            string strConn = $"server={server};port={port};username={username};password={password};database={database}";
            MySqlConnection conn = new MySqlConnection(strConn);

            
            try
            {
                // 데이터베이스 접속
                conn.Open();
                
                // SQL 실행
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `user1`";
                
                MySqlDataReader rerder = cmd.ExecuteReader();

                // 결과 출력
                while (rerder.Read())
                {
                    Console.WriteLine("{0},{1},{2},{3}", rerder[0], rerder[1], rerder[2], rerder[3]);
                }

            }
            catch (Exception e)
            {
                // 예외가 발생했을 땨 처리할 코드 작성
                Console.WriteLine("실패 :" + e.Message);
            }
            finally
            {
                // 데이터베이스 종료
                conn.Close();
                Console.WriteLine("종료...");
            }
        }
    }
}
