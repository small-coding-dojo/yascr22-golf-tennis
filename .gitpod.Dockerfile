FROM gitpod/workspace-dotnet:2022-11-09-13-54-49

# Install custom tools, runtimes, etc.
# For example "bastet", a command-line tetris clone:
# RUN brew install bastet
#
# More information: https://www.gitpod.io/docs/config-docker/

RUN curl -sL install.mob.sh | sudo sh
