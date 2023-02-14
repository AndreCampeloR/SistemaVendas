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
                <button class="btn btn-success" @click="editarcliente(cliente.id)">Editar</button>
                <button class="btn btn-danger" @click="excluircliente(cliente)">Excluir</button>
              </td>
            </tr>
          </tbody>
      </table>
    </div>
  </template>
  
  <script>
  import clienteDataService from '../../services/clienteDataService';
  export default {
    name: "TabelaListarcliente",
    data() {
      return{
        clientees: []
      }
    },
    methods: {
      obterclientees() {
        clienteDataService.listar()
          .then(response => this.clientees = response.data)
      },
      editarcliente(id){
        this.$router.push("/cliente/atualizar/"+id)
      },
      async excluircliente(cliente){
        if(confirm(`Tem certeza que deseja excluir o cliente ${cliente.nome}`)){
          await clienteDataService.deletar(cliente.id)
          this.obterclientees();
        }
      }
    },
    mounted(){
      this.obterclientees()
    }
  }
  </script>
  
  <style>
  </style>