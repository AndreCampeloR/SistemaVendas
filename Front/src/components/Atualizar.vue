<template>
    <div id="cadastro-vendedor">
      <h3>Atualiazar Vendedor</h3>
      <div class="form" style="padding: 1%;">
          <div>
              <label for="" class="form-label">Id</label>
              <input type="text" class="form-control" required placeholder="Id" v-model="this.$route.params.id" disabled>
          </div>
          <div>
              <label for="" class="form-label">Nome</label>
              <input type="text" class="form-control" required placeholder="Nome" v-model="vendedor.nome">
          </div>
          <div>
              <label for="" class="form-label">Login</label>
              <input type="text" class="form-control" required placeholder="Login" v-model="vendedor.login" disabled>
          </div>
          <div>
              <label for="" class="form-label">Email</label>
              <input type="text" class="form-control" required placeholder="Email" v-model="vendedor.email">
          </div>
          <div>
              <label for="" class="form-label">Telefone</label>
              <input type="text" class="form-control" required placeholder="Telefone" v-model="vendedor.telefone">
          </div>
          <div>
              <label for="" class="form-label">Cpf</label>
              <input type="text" class="form-control" required placeholder="Cpf" v-model="vendedor.cpf">
          </div>
          <div>
              <label for="" class="form-label">Senha</label>
              <input type="password" class="form-control" required v-model="updateVendedor.senha">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="atualizarVendedor">Cadastrar</button>
      </div>
    </div>
  </template>
  
  <script>
  import VendedorDataService from '../../services/VendedorDataService';
  export default {
      name: "FuncionarioCadastro",
      data(){
          return{
              vendedor: {
              },
              updateVendedor: {
                  nome: "",
                  email: "",
                  login: "",
                  telefone: "",
                  cpf: "",
                  senha: ""
              }
          }
      },
      methods: {
          atualizarVendedorData(){
              this.updateVendedor.login = this.vendedor.login
              this.updateVendedor.nome = this.vendedor.nome
              this.updateVendedor.email = this.vendedor.email
              this.updateVendedor.telefone = this.vendedor.telefone
              this.updateVendedor.cpf = this.vendedor.cpf
          },
          obterVendedor(id){
              VendedorDataService.obterPorId(id)
                  .then((response) => {
                      console.log(response.data)
                      this.vendedor = response.data;
                  })
          },
          atualizarVendedor(){
              this.atualizarVendedorData()
              VendedorDataService.atualizar(this.$route.params.id, this.updateVendedor)
                  .then(() => {
                      this.$router.push('vendedor/listar')
                  })
          },
          
          
      },
      mounted(){
          this.obterVendedor(this.$route.params.id)
      }
  }
  </script>
  
  <style>
  </style>