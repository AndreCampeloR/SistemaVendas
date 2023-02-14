<template>
    <div class="col-7">
      <table class="table table-striped">
          <thead>
            <tr>
              <th scope="col">#</th>
              <th scope="col">Nome</th>
              <th scope="col">Login</th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="(cliente, index) in clientes" :key="index">
              <th scope="row">{{ cliente.id }}</th>
              <td>{{ cliente.nome }}</td>
              <td>{{ cliente.login }}</td>
              <td>
                <button class="btn btn-success" @click="editarCliente(cliente.id)">Editar</button>
                <button class="btn btn-danger" @click="excluirCliente(cliente)">Excluir</button>
              </td>
            </tr>
          </tbody>
      </table>
    </div>
  </template>
  
  <script>
  import ClienteDataService from '../../services/ClienteDataService';
  export default {
    name: "TabelaListarCliente",
    data() {
      return{
        clientes: []
      }
    },
    methods: {
      obterClientes() {
        ClienteDataService.listar()
          .then(response => this.clientes = response.data)
      },
      editarCliente(id){
        this.$router.push("/cliente/atualizar/"+id)
      },
      async excluirCliente(cliente){
        if(confirm(`Tem certeza que deseja excluir o cliente ${cliente.nome}`)){
          await ClienteDataService.deletar(cliente.id)
          this.obterClientes();
        }
      }
    },
    mounted(){
      this.obterClientes()
    }
  }
  </script>
  
  <style>
  </style>