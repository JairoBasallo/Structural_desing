using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Structural_Desing.Wall;
using System.Web.UI.WebControls;
using TreeView = System.Windows.Controls.TreeView;
using Structural_Desing.Wall.Entidades;

namespace Structural_Desing
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        System.IO.StreamReader solicitation;
        public void create_walls(object sender, RoutedEventArgs e)
        {
            var masory_wall = load_walls();
            Console.WriteLine(masory_wall);

        }

        //funcion para cargar los muros
        private object load_walls()
        {
            Console.WriteLine("aca");
            List<Wall_1> walls = new List<Wall_1>();
            
            List<string> wall_id = new List<string>();
            List<string> length_wall = new List<string>();
            List<string> com_top = new List<string>();
            List<string> com_bot = new List<string>();

            String[] solicitation_1 = Load_Solicitation();
            
            List<String> story_wall = new List<string>();
            List<String> height_wall = new List<string>();

            List<String> combination = new List<string>();

            foreach (String aaaa in solicitation_1)
            {
                if (aaaa.Contains("[["))
                {
                    wall_id.Add(Regex.Replace(aaaa, @"\s+", " ").Trim().Split(' ')[4]);
                    length_wall.Add(Regex.Replace(aaaa, @"\s+", " ").Trim().Split(' ')[12]);
                }
                if (aaaa.Contains("Comb"))
                {
                    combination.Add(Regex.Replace(aaaa, @"\s+", " ").Trim().Split(' ')[0]);
                }
                if (aaaa.Contains("TOP"))
                {
                    var new_line = Regex.Replace(aaaa, @"\s+", " ").Trim().Split('\n')[0];
                    com_top.Add(new_line);                   
                }
                if (aaaa.Contains("BOT"))
                {
                    com_bot.Add(Regex.Replace(aaaa, @"\s+", " ").Trim().Split('\n')[0]);
                }

            }
            

            for (var i = 0; i < length_wall.Count; i++)
            {
                //Console.WriteLine(wall_id[i]);

                walls.Add( new Wall_1(
                    wall_id[i],
                    new Geometry_element(12, float.Parse(length_wall[i])),
                    new Solicitations( solicitaciones(combination, com_top, com_bot, wall_id[i]))
                    ));
            }

            foreach (var x in walls)
            {
                murosasd.Items.Add(x.Wall_id);
            }
            return walls;    
        }
        //func to create solicitations
        private List<Combination> solicitaciones(List<string> combination, List<string> com_top, List<string> com_bot, string wall_id)
        {
            
            
            
            //create combinations
            List<Combination> combinaciones = new List<Combination>();
            
            {
                //Console.WriteLine(wall_id);
                int j = 0;
                foreach (var n in com_top)
                {
                    if (n.Split(' ')[0] == wall_id)
                    {
                        for (var i = 0; i < combination.Count-1 ; i++)
                        {
                            //Console.WriteLine(i);
                            var com_top_split = com_top[i+j].Split(' ');
                            var com_bot_split = com_bot[i+j].Split(' ');
                            if (i == 0)
                            {
                                combinaciones.Add(
                                    new Combination(
                                    combination[i],
                                    com_top_split[5],
                                    com_bot_split[1],
                                    com_top_split[7],
                                    com_bot_split[3],
                                    com_top_split[9],
                                    com_bot_split[5]));
                            }
                            else
                            {
                                combinaciones.Add(
                                    new Combination(
                                    combination[i],
                                    com_top_split[2],
                                    com_bot_split[1],
                                    com_top_split[4],
                                    com_bot_split[3],
                                    com_top_split[6],
                                    com_bot_split[5]));
                            }
                        }
                    }
                    j++;
                }    
            }
            
            return combinaciones;
        }



        private String[] Load_Solicitation()
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a ANL file",
                Filter = "Midas files (*.ANL)|*.ANL",
                Title = "Open anl file"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                solicitation = new System.IO.StreamReader(openFileDialog.FileName);
            }

            String[] texto = solicitation.ReadToEnd().Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
                );
            return texto;
        }

        private void OnTreeViewSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            MyTextBlock.Text = "asdsdads";
        }

        private void TreeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            /*
            MyTextBlock.Text = "asdsdads";
            Window1 miventana = new Window1
            {
                Owner = this
            };
            miventana.ShowDialog();
            */
            var aaaaaa = (TreeView)sender;

            Console.WriteLine(aaaaaa.SelectedValue.ToString());

           

        }
    }
}
