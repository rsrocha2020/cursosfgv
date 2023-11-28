Projeto ASP .NET Core MVC que cria uma lista de objetos CursoInfo e exibe as informações sobre os cursos em uma View.

Dockerfile gerado no ambiente do VS 2023.

Comando usado para gerar a imagem: docker build -f frontend/Dockerfile -t cursosfgv .

########## Arquivo de Deployment frontend-deploy.yaml ##########
################################################################
---
apiVersion: v1
kind: Namespace
metadata:
  name: dotnetcore
---
kind: RoleBinding
apiVersion: rbac.authorization.k8s.io/v1
metadata:
  name: rolebinding-cluster-user-administrator
  namespace: dotnetcore
roleRef:
  kind: ClusterRole
  name: edit
  apiGroup: rbac.authorization.k8s.io
subjects:
- kind: User
  name: sso:user@dominio
  apiGroup: rbac.authorization.k8s.io
---
apiVersion: rbac.authorization.k8s.io/v1
kind: ClusterRoleBinding
metadata:
  name: administrator-cluster-role-binding
roleRef:
  kind: ClusterRole
  name: psp:vmware-system-privileged
  apiGroup: rbac.authorization.k8s.io
subjects:
- kind: Group
  name: system:authenticated
  apiGroup: rbac.authorization.k8s.io
---
apiVersion: apps/v1
kind: Deployment
metadata:
  name: cursosfgv
  namespace: dotnetcore
spec:
  replicas: 1
  template:
    metadata:
      labels:
        app: cursosfgv
    spec:
      containers:
      - name: cursosfgv
        image: rodrigosrocha/cursosfgv
        ports:
        - containerPort: 80
        env:
        - name: ASPNETCORE_URLS
          value: http://*:80
  selector:
    matchLabels:
        app: cursosfgv

########## Arquivo Service frontend-service.yaml ##########
###########################################################
---
apiVersion: v1
kind: Service
metadata:
  name: cursosfgv
  namespace: dotnetcore
spec:
  selector:
    app: cursosfgv
  ports:
    - protocol: TCP
      port: 8080
      targetPort: 80
  type: LoadBalancer

########## Acessar a app: http://IP_ou_FQDN:8080 ##########
###########################################################