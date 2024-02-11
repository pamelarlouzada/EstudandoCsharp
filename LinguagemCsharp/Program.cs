
using System.Drawing;

Console.WriteLine("Iniciando redimensionador");
Thread thread = new Thread(Redimensionar);
thread.Start();


static void Redimensionar()
{
    #region "Diretórios"
    string diretorioEntrada = "Arquivos_Entradas";
    string diretorioFinalizado = "Arquivos_Finalizados";
    string diretorioRedimensionado = "Arquivos_Redimensionados";

    if (!Directory.Exists(diretorioEntrada))
    {
        Directory.CreateDirectory(diretorioEntrada);
    }
    if (!Directory.Exists(diretorioFinalizado))
    {
        Directory.CreateDirectory(diretorioFinalizado);
    }
    if (!Directory.Exists(diretorioRedimensionado))
    {
        Directory.CreateDirectory(diretorioRedimensionado);
    }
    #endregion

    FileStream fileStream;
    FileInfo fileInfo;
    while (true)
    {
        // meu programa vai olhar para pasta de entrada
        // se tiver arquivo, ele irá redimensionar
        var arquivosEntrada = Directory.EnumerateFiles(diretorioEntrada);

        // ler o tamanho que irá redimensionar
        int novaAltura = 200;

        foreach (var arquivo in arquivosEntrada)
        {
            fileStream = new FileStream(arquivo, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            fileInfo = new FileInfo(arquivo);

            string caminho = Environment.CurrentDirectory + @"\" + diretorioRedimensionado + @"\" +
                            DateTime.Now.Millisecond.ToString() + "_" + fileInfo.Name ;

            //Console.WriteLine(file);

            // Redimensiona
            Redimensionador(Image.FromStream(fileStream), novaAltura, caminho);
            fileStream.Close();

            string caminhoFinalizado = Environment.CurrentDirectory + @"\" + diretorioFinalizado 
                + @"\" + fileInfo.Name;

            // move arquivos de entrada para finalizados
            fileInfo.MoveTo(caminhoFinalizado);
        }

        Thread.Sleep(new TimeSpan(0, 0, 2));
    }

    static void Redimensionador(Image imagem, int altura, string caminho)
    {
        double ratio = (double)altura/imagem.Height;
        int novaLargura = (int)(imagem.Width * ratio);
        int novaAltura = (int)(imagem.Height * ratio);

        Bitmap novaImagem = new Bitmap(novaLargura, novaAltura);
        using(Graphics g = Graphics.FromImage(novaImagem))
        {
            g.DrawImage(imagem, 0, 0, novaLargura, novaAltura);
        }
        novaImagem.Save(caminho);
        imagem.Dispose();
    } 
}



