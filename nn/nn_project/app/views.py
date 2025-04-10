from pprint import pprint
from django.db import connection
from django.shortcuts import render, redirect

from nn_project.wsgi import application


def dictfetchall(cursor):
    columns = [col[0] for col in cursor.description]
    return [dict(zip(columns, row)) for row in cursor.fetchall()]

def main(request):
    id_user = None;
    template = 'main.html'
    context = {}
    with connection.cursor() as cursor:
        cursor.execute("SELECT * from nn.statuses_get();")
        statuses = dictfetchall(cursor)
        #pprint(statuses)
        context['statuses'] = statuses
    with connection.cursor() as cursor:
        cursor.execute("SELECT * from nn.applications_get(%s);",(id_user,))
        apps = dictfetchall(cursor)
        #pprint(apps)
        applications =[]
        ids= []
        for app in apps:
            if app['id_application'] not in ids:
                application = {}
                application['id_application'] = app['id_application']
                application['id_user'] = app['id_user']
                application ['car_number'] = app['car_number']
                application ['description'] = app['description']
                application ['id_status'] = app['id_status']
                application ['title'] = app['title']
                application['images'] = []
                if app['id_image']:
                    image ={}
                    image['id_image']= app['id_image']
                    image['file_name'] = app['file_name']
                    image['file_ext'] = app['file_ext']
                    application['images'].append(image)
                applications.append(application)
                ids.append(app['id_application'])
        else:
            for application in applications:
                if app['id_application'] == application['id_application']:
                    image ={}
                    image['id_image']= app['id_image']
                    image['file_name'] = app['file_name']
                    image['file_ext'] = app['file_ext']
                    application['images'].append(image)
            context['applications'] = applications
    return render(request,template,context)

# Create your views here.
def signup(request):
    template = 'signup.html'
    context = {}
    return render(request,template,context)

def login(request):
    template = 'login.html'
    context = {}
    return render(request,template,context)

def newapp(request):
    template = 'newapp.html'
    context = {}
    return render(request,template,context)
def logout(request):
    return redirect('main')