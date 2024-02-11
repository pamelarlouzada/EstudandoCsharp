using System;
using System.IO;
using System.Threading;
using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando redimensionador e compactador de imagens");
        Thread thread = new Thread(RedimensionarECompactar);
        thread.Start();

        Console.ReadLine(); // Mantém a aplicação em execução para o propósito deste exemplo.
    }

    static void RedimensionarECompactar()
    {
        string diretorioEntrada = "Arquivos_Entradas";
        string diretorioFinalizado = "Arquivos_Finalizados";
        string diretorioRedimensionado = "Arquivos_Redimensionados";

        if (!Directory.Exists(diretorioEntrada))
            Directory.CreateDirectory(diretorioEntrada);
        if (!Directory.Exists(diretorioFinalizado))
            Directory.CreateDirectory(diretorioFinalizado);
        if (!Directory.Exists(diretorioRedimensionado))
            Directory.CreateDirectory(diretorioRedimensionado);

        while (true)
        {
            var arquivosEntrada = Directory.EnumerateFiles(diretorioEntrada);

            foreach (var arquivo in arquivosEntrada)
            {
                try
                {
                    // Redimensionar e compactar a imagem
                    RedimensionarECompactarImagem(arquivo, diretorioRedimensionado, diretorioFinalizado);

                    // Mover o arquivo de entrada para o diretório de arquivos finalizados
                    string caminhoFinalizado = Path.Combine(diretorioFinalizado, Path.GetFileName(arquivo));
                    File.Move(arquivo, caminhoFinalizado);

                    Console.WriteLine($"Redimensionamento e compactação concluídos para {Path.GetFileName(arquivo)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao processar arquivo {arquivo}: {ex.Message}");
                }
            }

            Thread.Sleep(TimeSpan.FromSeconds(2)); // Aguarda 2 segundos antes de verificar novamente
        }
    }

    static void RedimensionarECompactarImagem(string caminhoImagem, string diretorioRedimensionado, string diretorioFinalizado)
    {
        // Carregar a imagem original a ser compactada
        using (var originalImagem = Aspose.Imaging.Image.Load(caminhoImagem))
        {
            // Criar as opções de imagem para compactação
            var opcoesImagem = new JpegOptions()
            {
                CompressionType = JpegCompressionMode.Progressive, // Usar compressão progressiva
                Quality = 30 // Ajustar a qualidade da imagem (0 a 100)
            };

            // Caminho para o arquivo redimensionado e compactado
            string caminhoRedimensionado = Path.Combine(diretorioRedimensionado, Path.GetFileName(caminhoImagem));

            // Salvar a imagem redimensionada e compactada no disco
            originalImagem.Save(caminhoRedimensionado, opcoesImagem);
        }
    }
}
