﻿using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseShortTarefasJson
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public TarefasPrioridade Prioridade { get; set; }
    public DateTime RealizarAte { get; set; }
    public TarefasStatus Status { get; set; }
}
