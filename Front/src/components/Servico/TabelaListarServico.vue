<template>
    <div class="col-7">
      <table class="table table-striped">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Nome</th>
              <th scope="col">descricao</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(servico, index) in servicos" :key="index">
              <th scope="row">{{ servico.id }}</th>
              <td>{{ servico.nome }}</td>
              <td>{{ servico.descricao }}</td>
              <td>
                <button class="btn btn-success" @click="editarServico(servico.id)">Editar</button>
                <button class="btn btn-danger" @click="excluirServico(servico)">Excluir</button>
              </td>
            </tr>
          </tbody>
      </table>
    </div>
  </template>
  
  <script>
  import ServicoDataService from '../../services/ServicoDataService';
  export default {
    name: "TabelaListarServico",
    data() {
      return{
        servicos: []
      }
    },
    methods: {
      obterServicos() {
        ServicoDataService.listar()
          .then(response => this.servicos = response.data)
      },
      editarServico(id){
        this.$router.push("/servico/atualizar/"+id)
      },
      async excluirServico(servico){
        if(confirm(`Tem certeza que deseja excluir o servico ${servico.nome}`)){
          await ServicoDataService.deletar(servico.id)
          this.obterServicos();
        }
      }
    },
    mounted(){
      this.obterServicos()
    }
  }
  </script>
  
  <style>
  </style>